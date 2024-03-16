using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace dochazkovy_system
{
    public partial class Vypis_Form : Form
    {
        private SQLiteConnection sqliteConnection;

        public Vypis_Form()
        {
            InitializeComponent();
            sqliteConnection = new SQLiteConnection("Data Source=dochazkovy_system.db;Version=3;");
            sqliteConnection.Open(); 
            LoadEmployees();         
            LoadMonths();
        }

        private void Vypis_Form_Load(object sender, EventArgs e)
        {
           
            LoadEmployees();            
            LoadMonths();
        }

        private void LoadEmployees()
        {           
            string selectAllEmployeesQuery = "SELECT FirstName || ' ' || LastName AS FullName FROM Employees";

            using (SQLiteCommand selectAllEmployeesCommand = new SQLiteCommand(selectAllEmployeesQuery, sqliteConnection))
            using (SQLiteDataReader reader = selectAllEmployeesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string fullName = reader["FullName"].ToString();
                    zamestnanecCombo.Items.Add(fullName);
                }
            }
        }

        private void LoadMonths()
        {
        
            string[] months = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            months = Array.FindAll(months, m => !string.IsNullOrEmpty(m)); 
            mesicCombo.Items.AddRange(months);
        }

        private void zobrazitButton_Click(object sender, EventArgs e)
        {          
            string selectedEmployee = zamestnanecCombo.SelectedItem.ToString();
            string selectedMonth = mesicCombo.SelectedItem.ToString();           
            string[] nameParts = selectedEmployee.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];            
            string selectHoursWorkedQuery = "SELECT HoursWorked FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";
            using (SQLiteCommand selectHoursWorkedCommand = new SQLiteCommand(selectHoursWorkedQuery, sqliteConnection))
            {
                selectHoursWorkedCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectHoursWorkedCommand.Parameters.AddWithValue("@LastName", lastName);                
                object result = selectHoursWorkedCommand.ExecuteScalar();
                
                if (result != null)
                {                   
                    DatailVypis_DataGridView.DataSource = new[] { new { Employee = selectedEmployee, Month = selectedMonth, HoursWorked = result.ToString() } };
                }
                else
                {
                    MessageBox.Show("Odpracované hodiny pro vybraného zaměstnance a měsíc nejsou k dispozici.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private double GetHoursWorked(string employeeName, string month)
        {           
            string[] nameParts = employeeName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            
            string selectHoursWorkedQuery = "SELECT ArrivalTime, LeavingTime " +
                                             "FROM Attendance " +
                                             "JOIN Employees ON Attendance.EmployeeID = Employees.ID " +
                                             "WHERE Employees.FirstName = @FirstName AND Employees.LastName = @LastName " +
                                             "AND strftime('%m', ArrivalTime) = @Month";

            double totalHoursWorked = 0;

            using (SQLiteCommand selectHoursWorkedCommand = new SQLiteCommand(selectHoursWorkedQuery, sqliteConnection))
            {
                selectHoursWorkedCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectHoursWorkedCommand.Parameters.AddWithValue("@LastName", lastName);
                selectHoursWorkedCommand.Parameters.AddWithValue("@Month", month.PadLeft(2, '0')); // Převedení měsíce na formát MM

                using (SQLiteDataReader reader = selectHoursWorkedCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {                       
                        DateTime arrivalTime = DateTime.ParseExact(reader["ArrivalTime"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime leavingTime = DateTime.ParseExact(reader["LeavingTime"].ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                        double hoursWorked = (leavingTime - arrivalTime).TotalHours;

                       
                        hoursWorked = Math.Round(hoursWorked * 2, MidpointRounding.AwayFromZero) / 2;
                        
                        totalHoursWorked += hoursWorked;
                    }
                }
            }

            return totalHoursWorked;
        }





        private void ShowResult(string employeeName, string month, double hoursWorked)
        {          
            DataTable dt = new DataTable();
            dt.Columns.Add("Zamestnanec", typeof(string));
            dt.Columns.Add("Mesic", typeof(string));
            dt.Columns.Add("Odpracovane hodiny", typeof(double));

            dt.Rows.Add(employeeName, month, hoursWorked);

            DatailVypis_DataGridView.DataSource = dt;
        }
        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            sqliteConnection.Close();
        }
    }
}
