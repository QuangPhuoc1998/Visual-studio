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

namespace SQL_v2
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_get_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllData().Tables[0];
        }
        DataSet GetAllData()
        {
            DataSet data = new DataSet();
            //
            string query = "select * from NguoiDung";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionstring))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
                return data;
        }
    }
}
