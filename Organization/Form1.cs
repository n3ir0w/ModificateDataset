using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization
{
    public partial class Form1 : Form
    {
        string login;
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            password = passwordTextBox.Text;

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LIGHT;Initial Catalog=Organization;Integrated Security=True");
                using (connection)
                {
                    connection.Open();
                    var cmdSign = new SqlCommand("select Логин, Пароль from Авторизация where Логин='" + login + "' and Пароль ='"+ password +"';", connection);
                    var readerSign = cmdSign.ExecuteReader();
                    if (readerSign.HasRows)
                    {
                        Menu f = new Menu();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность введенных данных.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных.");
            }

            
        }

        private void loginTextBox_Enter(object sender, EventArgs e)
        {
            loginTextBox.Clear();
            loginTextBox.ForeColor = Color.Black;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            passwordTextBox.ForeColor = Color.Black;
        }
    }
}
