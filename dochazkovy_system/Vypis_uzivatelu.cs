using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace dochazkovy_system
{
    public partial class Vypis_uzivatelu : Form
    {
        private SQLiteConnection sqliteConnection;
        private DataTable dataTable;

        public Vypis_uzivatelu()
        {
            InitializeComponent();
            sqliteConnection = new SQLiteConnection("Data Source=dochazkovy_system.db;Version=3;");
            sqliteConnection.Open();
            LoadUsersData();
            HeaderToCzech();
        }
        private void HeaderToCzech()
        {
            dataGridView1.Columns["FirstName"].HeaderText = "Jméno";
            dataGridView1.Columns["LastName"].HeaderText = "Příjmení";
            dataGridView1.Columns["HourlyRate"].HeaderText = "Hodinovka";
            dataGridView1.Columns["HoursWorked"].HeaderText = "Odpracováno";
            dataGridView1.Columns["Position"].HeaderText = "Pozice";
        }

        private void LoadUsersData()
        {
            string query = "SELECT ID, FirstName, LastName, HourlyRate, HoursWorked, Position FROM Employees"; // Upřesněte sloupce, které chcete zobrazit
            dataTable = LoadDataFromSQLite(query);
            dataGridView1.DataSource = dataTable;            
            dataGridView1.Columns["ID"].Visible = false;
        }

        private DataTable LoadDataFromSQLite(string query)
        {
            DataTable dt = new DataTable();
            using (SQLiteCommand sqlCommand = new SQLiteCommand(query, sqliteConnection))
            {
                using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                string newValue = row.Cells[e.ColumnIndex].Value.ToString();
                int id = Convert.ToInt32(row.Cells["ID"].Value); // Předpokládám, že sloupec ID existuje
                UpdateData(id, columnName, newValue);
            }
        }

        private void UpdateData(int id, string columnName, string newValue)
        {
            string query = $"UPDATE Employees SET {columnName} = @NewValue WHERE ID = @ID";
            using (SQLiteCommand sqlCommand = new SQLiteCommand(query, sqliteConnection))
            {
                sqlCommand.Parameters.AddWithValue("@NewValue", newValue);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void UlozitZmenyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable != null && dataTable.GetChanges() != null)
                {                  
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                        {
                            int id = Convert.ToInt32(row["ID"]);
                            foreach (DataColumn col in dataTable.Columns)
                            {
                                string columnName = col.ColumnName;
                                string newValue = row[col].ToString();
                                UpdateData(id, columnName, newValue);
                            }
                        }
                    }
                    dataTable.AcceptChanges();

                    MessageBox.Show("Změny byly úspěšně uloženy do databáze.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nejsou žádné změny k uložení.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při ukládání změn do databáze: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            sqliteConnection.Close();
        }

        // button pro smazani - smaze i jeho zaznamy o dochazce
        private void vymazButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Opravdu chcete vymazat vybraného zaměstnance včetně jeho záznamů?", "Potvrzení vymazání", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                    string deleteEmployeeQuery = "DELETE FROM Employees WHERE ID = @ID";
                    using (SQLiteCommand deleteEmployeeCommand = new SQLiteCommand(deleteEmployeeQuery, sqliteConnection))
                    {
                        deleteEmployeeCommand.Parameters.AddWithValue("@ID", id);
                        deleteEmployeeCommand.ExecuteNonQuery();
                    }
                    string deleteAttendanceQuery = "DELETE FROM Attendance WHERE EmployeeID = @ID";
                    using (SQLiteCommand deleteAttendanceCommand = new SQLiteCommand(deleteAttendanceQuery, sqliteConnection))
                    {
                        deleteAttendanceCommand.Parameters.AddWithValue("@ID", id);
                        deleteAttendanceCommand.ExecuteNonQuery();
                    }
                    LoadUsersData();
                }
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný zaměstnanec k vymazání.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zpetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }

        private void Vypis_uzivatelu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
