using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace dochazkovy_system
{
    public partial class userReg : Form
    {
        private SQLiteConnection sqliteConnection;

        public userReg()
        {
            InitializeComponent();
            sqliteConnection = new SQLiteConnection("Data Source=dochazkovy_system.db;Version=3;");
            sqliteConnection.Open();
            CreateDB(); 
        }

        private void CreateDB()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Employees (" +
                                      "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                      "FirstName TEXT, " +
                                      "LastName TEXT, " +
                                      "HourlyRate DECIMAL, " +
                                      "HoursWorked DECIMAL DEFAULT 0, " + 
                                      "Position TEXT)";
            using (SQLiteCommand createCommand = new SQLiteCommand(createTableQuery, sqliteConnection))
            {
                createCommand.ExecuteNonQuery();
            }
          
            string createAttendanceTableQuery = "CREATE TABLE IF NOT EXISTS Attendance (" +
                                                 "ID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                 "EmployeeID INTEGER, " +
                                                 "ArrivalTime DATETIME, " +
                                                 "LeavingTime DATETIME)";
            using (SQLiteCommand createAttendanceCommand = new SQLiteCommand(createAttendanceTableQuery, sqliteConnection))
            {
                createAttendanceCommand.ExecuteNonQuery();
            }
        }


        private void InsertEmployee(string firstName, string lastName, decimal hourlyRate, string position)
        {
            string insertQuery = "INSERT INTO Employees (FirstName, LastName, HourlyRate, Position) " +
                                 "VALUES (@FirstName, @LastName, @HourlyRate, @Position)";
            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, sqliteConnection))
            {
                insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                insertCommand.Parameters.AddWithValue("@LastName", lastName);
                insertCommand.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                insertCommand.Parameters.AddWithValue("@Position", position);
                insertCommand.ExecuteNonQuery();
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
            }
        }

        private void register_user_btn_Click(object sender, EventArgs e)
        {
            string firstName = jmeno_textbox.Text;
            string lastName = prijmeni_textbox.Text;
            decimal hourlyRate = Convert.ToDecimal(hodinovka_textbox.Text);
            string position = prac_pozice_textbox.Text;

            InsertEmployee(firstName, lastName, hourlyRate, position);

            MessageBox.Show("Employee registered successfully!");
        }     
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            sqliteConnection.Close();
        }
    }
}
