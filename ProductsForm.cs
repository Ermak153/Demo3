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
        DataTable dataTable = new DataTable();
        string connectionString = "Data Source=Neko;Initial Catalog=demo3;Integrated Security=True;Encrypt=False";
        string tableName = "Категория";

        public ProductsForm()
        {
            InitializeComponent();
            LoadTableNames();
            tablesCmbox.SelectedItem = "Категория";
            LoadData(tableName);
        }

        private void LoadTableNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    sCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME != 'sysdiagrams'", connection);
                    SqlDataReader reader = sCommand.ExecuteReader();
                    tablesCmbox.Items.Clear();
                    while (reader.Read())
                    {
                        tablesCmbox.Items.Add(reader["TABLE_NAME"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке списка таблиц: " + ex.Message);
                }
            }
        }

        private void LoadData(string tableName)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить эту строку?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string ID = dataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                        SqlCommand command = new SqlCommand($"DELETE FROM {tableName} WHERE ID = {ID}", connection);
                        command.ExecuteNonQuery();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    sAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sAdapter);
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

        private void tablesCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesCmbox.SelectedItem != null)
            {
                tableName = tablesCmbox.SelectedItem.ToString();
                LoadData(tableName);
            }
        }
    }
}