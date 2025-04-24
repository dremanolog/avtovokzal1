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

namespace avtovokzal
{
    public partial class Регистрация : Form
    {
        private string connectionString = "Data Source=DESKTOP-110AQHB\\SQLEXPRESS;Initial Catalog=avtovokzal;Integrated Security=True";
        public Регистрация()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            string fio = textBox4.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Пользователи (Логин, Пароль, ФИО) VALUES (@login, @password, @fio)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fio", fio);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно");
                    Form Вход = new Вход();
                    Вход.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Пользователь с таким логином уже существует");
                    else
                        MessageBox.Show("Ошибка: Пользователь с таким логином уже существует");
                }
            }
        }
    }
}
