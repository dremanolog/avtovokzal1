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
    public partial class Главное_меню : Form
    {
        private string connectionString = "Data Source=DESKTOP-110AQHB\\SQLEXPRESS;Initial Catalog=avtovokzal;Integrated Security=True";
        public Главное_меню()
        {
            InitializeComponent();
        }

        private void Главное_меню_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID, Name FROM Cities";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmdFrom.DataSource = dt.Copy();
                    cmdFrom.DisplayMember = "Name";
                    cmdFrom.ValueMember = "ID";

                    cmdTo.DataSource = dt;
                    cmdTo.DisplayMember = "Name";
                    cmdTo.ValueMember = "ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int fromId = (int)cmdFrom.SelectedValue;
            int toId = (int)cmdTo.SelectedValue;
            DateTime depDate = dtDeparture.Value.Date;
            DateTime retDate = dtReturn.Value.Date;
            int passengers = (int)numPassengers.Value;

            string query = @"SELECT T.ID, C1.Name AS FromCity, C2.Name AS ToCity, 
                            T.DepartureDate, T.ReturnDate, T.SeatsAvailable
                     FROM Trips T
                     JOIN Cities C1 ON T.FromCityID = C1.ID
                     JOIN Cities C2 ON T.ToCityID = C2.ID
                     WHERE T.FromCityID = @from AND T.ToCityID = @to
                           AND T.DepartureDate = @dep AND T.ReturnDate = @ret
                           AND T.SeatsAvailable >= @passengers";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", fromId);
                cmd.Parameters.AddWithValue("@to", toId);
                cmd.Parameters.AddWithValue("@dep", depDate);
                cmd.Parameters.AddWithValue("@ret", retDate);
                cmd.Parameters.AddWithValue("@passengers", passengers);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvResults.DataSource = dt;
            }
        }
    }
}
        
    

