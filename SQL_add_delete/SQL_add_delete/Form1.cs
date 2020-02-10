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

namespace SQL_add_delete
{
    public partial class Quan_ly : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public Quan_ly()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=DESKTOP-VPC6GRQ\SQLDEV2020;Initial Catalog=Khach_san;Integrated Security=True";
        private void Quan_ly_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        void Load_data()
        {
            dataGridView1.DataSource = GetAllData().Tables[0];
        }
        DataSet GetAllData()
        {
            DataSet data = new DataSet();
            //
            string query = "select * from Quan_ly_khach_san";
            using (connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.ReadOnly = true;
            int i = dataGridView1.CurrentRow.Index;
            txt_maphong.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_dongia.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_sogiuong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cb_Tinhtrang.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText = "insert into Quan_ly_khach_san values('" + txt_maphong.Text + "','" + txt_dongia.Text + "','" + txt_sogiuong.Text + "','" + cb_Tinhtrang.Text + "')";
                command.ExecuteNonQuery();
              
                Load_data();
                connection.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText = "delete from Quan_ly_khach_san where Ma_phong = '"+txt_maphong.Text+"'";
                command.ExecuteNonQuery();
                
                Load_data();
                connection.Close();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionstring))
            {
                connection.Open();

                command = connection.CreateCommand();
                command.CommandText = "update Quan_ly_khach_san set Don_gia = '"+txt_dongia.Text+"', So_giuong = '"+txt_sogiuong.Text+ "', Tinh_trang = N'" + cb_Tinhtrang.Text + "' where Ma_phong = '" + txt_maphong.Text + "'";
                command.ExecuteNonQuery();

                Load_data();
                connection.Close();
            }
        }
    }
}
