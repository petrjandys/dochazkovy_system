using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace dochazkovy_system
{
    public partial class MainForm : Form
    {
        private SQLiteConnection sqliteConnection;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                sqliteConnection = new SQLiteConnection("Data Source=dochazkovy_system.db;Version=3;");
                sqliteConnection.Open();
                LoadArrivalsAndDepartures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při připojování k databázi, databáze se vytvoří přidáním prvního zaměstnance", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadArrivalsAndDepartures()
        {
            prichod_list.Items.Clear();
            odchod_list.Items.Clear();

            string selectAllEmployeesQuery = "SELECT DISTINCT Employees.FirstName, Employees.LastName " +
                                              "FROM Employees " +
                                              "WHERE Employees.ID NOT IN " +
                                              "(SELECT EmployeeID FROM Attendance WHERE LeavingTime IS NULL)";

            using (SQLiteCommand selectAllEmployeesCommand = new SQLiteCommand(selectAllEmployeesQuery, sqliteConnection))
            using (SQLiteDataReader reader = selectAllEmployeesCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    prichod_list.Items.Add($"{firstName} {lastName}");
                }
            }

            string selectArrivalsQuery = "SELECT DISTINCT FirstName, LastName FROM Employees " +
                                          "LEFT JOIN Attendance ON Employees.ID = Attendance.EmployeeID " +
                                          "WHERE ArrivalTime IS NOT NULL AND (LeavingTime IS NULL OR LeavingTime >= @CurrentTime)";
                   
            using (SQLiteCommand selectArrivalsCommand = new SQLiteCommand(selectArrivalsQuery, sqliteConnection))
            {
                selectArrivalsCommand.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

                using (SQLiteDataReader reader = selectArrivalsCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        odchod_list.Items.Add($"{firstName} {lastName}");
                    }
                }
            }
        }
        private void registrovatUzivateleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrace();
        }
        public void Registrace()
        {
            Registrace_Form userReg = new Registrace_Form();
            userReg.Show();
            LoadArrivalsAndDepartures();
            this.Hide();
        }

        private void prichod_btn_Click(object sender, EventArgs e)
        {        
            if (prichod_list.SelectedItem != null)
            {
                string selectedEmployee = prichod_list.SelectedItem.ToString();
                string[] nameParts = selectedEmployee.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];
              
                RecordArrival(firstName, lastName);
                LoadArrivalsAndDepartures();
                prichod_list.Items.Remove(selectedEmployee);
            }
            else
            {
                MessageBox.Show("Vyberte prosím uživatele před zaznamenáním příchodu.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void RecordArrival(string firstName, string lastName)
        {
            string selectUserIDQuery = "SELECT ID FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";
            using (SQLiteCommand selectUserIDCommand = new SQLiteCommand(selectUserIDQuery, sqliteConnection))
            {
                selectUserIDCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectUserIDCommand.Parameters.AddWithValue("@LastName", lastName);

                int employeeID = Convert.ToInt32(selectUserIDCommand.ExecuteScalar());

                string insertAttendanceQuery = "INSERT INTO Attendance (EmployeeID, ArrivalTime) " +
                                               "VALUES (@EmployeeID, @ArrivalTime)";
                using (SQLiteCommand insertAttendanceCommand = new SQLiteCommand(insertAttendanceQuery, sqliteConnection))
                {
                    insertAttendanceCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    insertAttendanceCommand.Parameters.AddWithValue("@ArrivalTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    insertAttendanceCommand.ExecuteNonQuery();
                }
            }
        }

        private void odchod_btn_Click(object sender, EventArgs e)
        {
            if (odchod_list.SelectedItem != null)
            {
                string selectedEmployee = odchod_list.SelectedItem.ToString();
                string[] nameParts = selectedEmployee.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                RecordLeaving(firstName, lastName);

                LoadArrivalsAndDepartures();
               
                odchod_list.Items.Remove(selectedEmployee);
            }
            else
            {
                MessageBox.Show("Vyberte prosím uživatele před zaznamenáním odchodu.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecordLeaving(string firstName, string lastName)
        {          
            string selectUserIDQuery = "SELECT ID FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";
            using (SQLiteCommand selectUserIDCommand = new SQLiteCommand(selectUserIDQuery, sqliteConnection))
            {
                selectUserIDCommand.Parameters.AddWithValue("@FirstName", firstName);
                selectUserIDCommand.Parameters.AddWithValue("@LastName", lastName);

                int employeeID = Convert.ToInt32(selectUserIDCommand.ExecuteScalar());

        
                string updateAttendanceQuery = "UPDATE Attendance SET LeavingTime = @LeavingTime " +
                                               "WHERE EmployeeID = @EmployeeID AND LeavingTime IS NULL";
                using (SQLiteCommand updateAttendanceCommand = new SQLiteCommand(updateAttendanceQuery, sqliteConnection))
                {
                    updateAttendanceCommand.Parameters.AddWithValue("@LeavingTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    updateAttendanceCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    updateAttendanceCommand.ExecuteNonQuery();
                }
                string calculateHoursQuery = "SELECT ArrivalTime FROM Attendance WHERE EmployeeID = @EmployeeID AND LeavingTime IS NOT NULL";
                using (SQLiteCommand calculateHoursCommand = new SQLiteCommand(calculateHoursQuery, sqliteConnection))
                {
                    calculateHoursCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                    SQLiteDataReader reader = calculateHoursCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime arrivalTime = Convert.ToDateTime(reader["ArrivalTime"]);
                        DateTime leavingTime = DateTime.Now;

                        double hoursWorked = (leavingTime - arrivalTime).TotalHours;

                        hoursWorked = Math.Round(hoursWorked * 2, MidpointRounding.AwayFromZero) / 2;

                    
                        string updateHoursWorkedQuery = "UPDATE Employees SET HoursWorked = @HoursWorked WHERE ID = @EmployeeID";
                        using (SQLiteCommand updateHoursWorkedCommand = new SQLiteCommand(updateHoursWorkedQuery, sqliteConnection))
                        {
                            updateHoursWorkedCommand.Parameters.AddWithValue("@HoursWorked", hoursWorked);
                            updateHoursWorkedCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                            updateHoursWorkedCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        private void vypisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypis_Form vypis_Form = new Vypis_Form();
            vypis_Form.Show();
            this.Hide();
        }

        private void registrovaníUzivateleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypis_uzivatelu vypis_Uzivatelu = new Vypis_uzivatelu();
            vypis_Uzivatelu.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void zavritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
