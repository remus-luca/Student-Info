using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MK5GMMO\\SQLEXPRESS;Initial Catalog=StudentInfo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void loadData()
        {
            cmd = new SqlCommand("Select * from StudentTable",con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Clear()
        {
            txtStudentID.Text = txtFName.Text = txtLName.Text = txtAge.Text = txtPhone.Text = txtAddress.Text = "";
            ComboBox1.SelectedIndex = 0;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtStudentID.Text = selectedRow.Cells[0].Value.ToString();
            txtLName.Text = selectedRow.Cells[1].Value.ToString();
            txtFName.Text = selectedRow.Cells[2].Value.ToString();
            txtAge.Text = selectedRow.Cells[3].Value.ToString();
            txtAddress.Text = selectedRow.Cells[4].Value.ToString();
            txtPhone.Text = selectedRow.Cells[5].Value.ToString();
            ComboBox1.SelectedItem = selectedRow.Cells[6].Value.ToString();
        }

        private void Parameters()
        {
            cmd.Parameters.AddWithValue("StudentID", txtStudentID.Text);
            cmd.Parameters.AddWithValue("LName", txtLName.Text);
            cmd.Parameters.AddWithValue("FName", txtFName.Text);
            cmd.Parameters.AddWithValue("Age", txtAge.Text);
            cmd.Parameters.AddWithValue("Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("Phone", txtPhone.Text);
            String courseText = ComboBox1.GetItemText(ComboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("course", courseText);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtStudentID.Text)|| String.IsNullOrEmpty(txtLName.Text) ||String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPhone.Text) || ComboBox1.SelectedIndex==0 ){
                MessageBox.Show("Complete all the required fields!");
                return;

            }
        }
    }
}
