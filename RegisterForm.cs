using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo3_2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void authLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Neko;Initial Catalog=demo3;Integrated Security=True;Encrypt=False";
            string name = nameRegTxb.Text;
            string login = loginRegTxb.Text;
            string password = passwordRegTxb.Text;
            string phone = phoneRegTxb.Text;
            string adress = adressRegTxb.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM Клиент WHERE Логин = @login", connection);
                    command.Parameters.AddWithValue("@login", login);
                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                    }
                    else
                    {
                        SqlCommand insertCommand = new SqlCommand("INSERT INTO Клиент (Имя, Телефон, Адрес_доставки, Логин, Пароль) VALUES (@name, @phone, @adress, @login, @password)", connection);
                        insertCommand.Parameters.AddWithValue("@name", name);
                        insertCommand.Parameters.AddWithValue("@phone", phone);
                        insertCommand.Parameters.AddWithValue("@adress", adress);
                        insertCommand.Parameters.AddWithValue("@login", login);
                        insertCommand.Parameters.AddWithValue("@password", password);
                        try
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка залупы");
                        }

                        MessageBox.Show("Регистрация успешна. Вы можете войти.");

                        ProductsForm productsForm = new ProductsForm();
                        productsForm.Show();
                        Hide();
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