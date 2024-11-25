using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo3_2
{
    public partial class ProductsForm : Form
    {
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        SqlDataReader sReader;
        DataTable dataTable = new DataTable();
        public string connectionString = "Data Source=Neko;Initial Catalog=demo3;Integrated Security=True;Encrypt=False";
        public string tableName = "Категория";
        public bool isSorted = false;

        public ProductsForm()
        {
            InitializeComponent();
            LoadTableNames();
            tablesCmbox.SelectedItem = "Категория";
            LoadData(tableName);
        }

        public void LoadTableNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME != 'sysdiagrams'", connection);
                    sReader = sCommand.ExecuteReader();
                    tablesCmbox.Items.Clear();
                    while (sReader.Read())
                    {
                        tablesCmbox.Items.Add(sReader["TABLE_NAME"].ToString());
                    }
                    sReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке списка таблиц: " + ex.Message);
                }
            }
        }

        public void LoadData(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    sAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                    dataTable = new DataTable();
                    sAdapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                    dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить эту строку?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string ID = dataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        sCommand = new SqlCommand($"DELETE FROM {tableName} WHERE ID = {ID}", connection);
                        sCommand.ExecuteNonQuery();
                        dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                        connection.Close();
                        LoadData(tableName);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    sAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                    sBuilder = new SqlCommandBuilder(sAdapter);
                    sAdapter.Update(dataTable);
                    connection.Close();
                    LoadData(tableName);
                }
                MessageBox.Show("Изменения успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        public void tablesCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesCmbox.SelectedItem != null)
            {
                tableName = tablesCmbox.SelectedItem.ToString();
                LoadData(tableName);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (dataTable.Columns.Count == 0 || !dataTable.Columns.Contains("ID"))
            {
                MessageBox.Show("Столбец 'ID' не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isSorted)
            {
                string columnName = "ID";
                dataTable.DefaultView.Sort = $"{columnName} ASC";
                isSorted = false;
            }

            else 
            {
                string columnname = "ID";
                dataTable.DefaultView.Sort = $"{columnname} DESC";
                isSorted = true;
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            string filterText = searchTextbox.Text.Trim();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        string cellValue = dataGridView.Rows[i].Cells[j].Value.ToString();
                        if (cellValue.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            dataGridView.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}