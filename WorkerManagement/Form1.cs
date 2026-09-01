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

namespace WorkerManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CompFix\Desktop\vstudio\WorkerManagement\WorkerManagement\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into Employee values(@employeeid,@employeename,@employeeemail,@salary)", con);
            cnn.Parameters.AddWithValue("@Employeeid", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", textBox2.Text);
            cnn.Parameters.AddWithValue("@EmployeeEmail", textBox3.Text);
            cnn.Parameters.AddWithValue("@Salary",Convert.ToDecimal(textBox4.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Record save successfully");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CompFix\Desktop\vstudio\WorkerManagement\WorkerManagement\Database1.mdf;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("select * from Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CompFix\Desktop\vstudio\WorkerManagement\WorkerManagement\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete Employee where employeeid=@employeeid", con);
            cnn.Parameters.AddWithValue("@EmployeeId", int.Parse(textBox1.Text));
            
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Record deleted successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CompFix\Desktop\vstudio\WorkerManagement\WorkerManagement\Database1.mdf;Integrated Security=True");
            SqlCommand cnn = new SqlCommand("select * from Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label8.Text = dt.Rows.Count.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
