using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Report_chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string source = @"Data Source = UNISYSTER\SQLEXPRESS; Initial Catalog = iimt; Integrated Security = True";
                SqlConnection con = new SqlConnection(source);
                con.Open();
                MessageBox.Show("connected");
                string sqlselectquery = "SELECT * FROM College_login WHERE ID = " + int.Parse(textBox1.Text);
                SqlCommand cmd = new SqlCommand(sqlselectquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = (dr["College_name"].ToString());
                }
                else
                {

                }
                con.Close();
            
        }
    }
}
