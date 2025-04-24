using System.Data.SqlClient;
namespace avtovokzal;
public partial class Вход : Form
{
    public Вход()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=DESKTOP-110AQHB\\SQLEXPRESS;Initial Catalog=avtovokzal;Integrated Security=True";
        string username = textBox1.Text;
        string password = textBox2.Text;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(1) FROM Пользователи WHERE Логин=@Логин AND Пароль=@Пароль";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Логин", username);
            cmd.Parameters.AddWithValue("@Пароль", password);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                MessageBox.Show("Добро пожаловать!");
                Form Главное_меню = new Главное_меню();
                Главное_меню.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин.");
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form Регистрация = new Регистрация();
        Регистрация.Show();
        this.Hide();
    }
}
