using System;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
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
            SetDefaultMonth();
        }
        private void SetDefaultMonth()
        {
            string currentMonth = DateTime.Now.ToString("MMMM", CultureInfo.CurrentCulture);
            mesicCombo.SelectedItem = currentMonth;
        }
        private void Vypis_Form_Load(object sender, EventArgs e)
        {

            LoadEmployees();
            LoadMonths();
            SetDefaultMonth();
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
            if (zamestnanecCombo.SelectedItem == null || mesicCombo.SelectedItem == null)
            {
                MessageBox.Show("Prosím vyberte zaměstnance a měsíc.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedEmployee = zamestnanecCombo.SelectedItem.ToString();
            string selectedMonth = mesicCombo.SelectedItem.ToString();
            string[] nameParts = selectedEmployee.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            string selectedMonthNumber = DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture).Month.ToString("00");

            string selectHoursWorkedQuery = "SELECT HoursWorked FROM Attendance " +
                                            "INNER JOIN Employees ON Attendance.EmployeeID = Employees.ID " +
                                            "WHERE Employees.FirstName = @FirstName AND Employees.LastName = @LastName " +
                                            "AND strftime('%m', Attendance.ArrivalTime) = @SelectedMonth";

            using (SQLiteCommand selectHoursWorkedCommand = new SQLiteCommand(selectHoursWorkedQuery, sqliteConnection))
            {
                selectHoursWorkedCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectHoursWorkedCommand.Parameters.AddWithValue("@LastName", lastName);
                selectHoursWorkedCommand.Parameters.AddWithValue("@SelectedMonth", selectedMonthNumber);
                object result = selectHoursWorkedCommand.ExecuteScalar();

                double hoursWorked = 0;

                if (result != null)
                {
                    hoursWorked = Convert.ToDouble(result);
                }

                double hourlyRate = GetHourlyRate(firstName, lastName);
                double salary = hoursWorked * hourlyRate;

                label10.Text = selectedEmployee;
                label9.Text = selectedMonth;
                label8.Text = hoursWorked.ToString();
                label7.Text = hourlyRate.ToString() + " Kč";
                label6.Text = salary.ToString() + " Kč";
            }
        }
        private double GetHourlyRate(string firstName, string lastName)
        {
            string selectHourlyRateQuery = "SELECT HourlyRate FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";
            using (SQLiteCommand selectHourlyRateCommand = new SQLiteCommand(selectHourlyRateQuery, sqliteConnection))
            {
                selectHourlyRateCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectHourlyRateCommand.Parameters.AddWithValue("@LastName", lastName);

                object result = selectHourlyRateCommand.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDouble(result);
                }
                else
                {
                    return 0;
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            sqliteConnection.Close();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedEmployee = label10.Text;
                string selectedMonth = label9.Text;
                double hoursWorked = Convert.ToDouble(label8.Text);
                double hourlyRate = Convert.ToDouble(label7.Text.Replace("Kč", ""));
                double salary = Convert.ToDouble(label6.Text.Replace(" Kč", ""));

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.FileName = $"{selectedEmployee}_vykaz.csv";
                saveFileDialog.Title = "Vyberte místo pro uložení souboru";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(selectedEmployee, selectedMonth, hoursWorked, hourlyRate, salary, saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Vypište prosím uživatele před exportem výpisu", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToCSV(string selectedEmployee, string selectedMonth, double hoursWorked, double hourlyRate, double salary, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, new System.Text.UTF8Encoding(true))) 
            {
                writer.WriteLine($"Mzda za mesic: {selectedMonth}");
                writer.WriteLine($"Zamestnanec: {selectedEmployee}");
                writer.WriteLine($"Odpracovane hodiny: {hoursWorked}");
                writer.WriteLine($"Hodinova sazba: {hourlyRate} Kč");
                writer.WriteLine($"Mzda: {salary} Kč");
            }

            MessageBox.Show($"Soubor úspěšně uložen", "Export dokončen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vypis_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void zpetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }
    }
}
