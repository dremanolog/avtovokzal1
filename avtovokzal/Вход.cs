using System.Data.SqlClient;
namespace avtovokzal;
public partial class ���� : Form
{
    public ����()
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
            string query = "SELECT COUNT(1) FROM ������������ WHERE �����=@����� AND ������=@������";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@�����", username);
            cmd.Parameters.AddWithValue("@������", password);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                MessageBox.Show("����� ����������!");
                Form �������_���� = new �������_����();
                �������_����.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("�������� ������ ��� �����.");
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Form ����������� = new �����������();
        �����������.Show();
        this.Hide();
    }
}
