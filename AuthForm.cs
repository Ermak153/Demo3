using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SqlHelper;

namespace demo3_2
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            EFCoreAdditional.ShowAll();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Neko;Initial Catalog=demo3;Integrated Security=True;Encrypt=False";
            string login = loginAuthTxb.Text;
            string password = passwdAuthTxb.Text;
            EFCoreAdditional.ShowTable("Auth");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT COUNT (1) FROM Клиент WHERE Логин = '{login}' AND Пароль = '{password}'";
                    SqlCommand command = new SqlCommand(query, connection);

                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Вход выполнен успешно");
                        ProductsForm productsForm = new ProductsForm();
                        productsForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность ввода данных");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }
    }
}
