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
            ComboBox1.SelectedIndex = 0;
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MK5GMMO\\SQLEXPRESS;Initial Catalog=StudentInfo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void loadData()
        {
            cmd = new SqlCommand("Select * from StudentTable", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ClearTextbox()
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
            cmd.Parameters.AddWithValue("Student_No", txtStudentID.Text);
            cmd.Parameters.AddWithValue("LName", txtLName.Text);
            cmd.Parameters.AddWithValue("FName", txtFName.Text);
            cmd.Parameters.AddWithValue("Age", txtAge.Text);
            cmd.Parameters.AddWithValue("Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("Phone", txtPhone.Text);
            String courseText = ComboBox1.GetItemText(ComboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("Course", courseText);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudentID.Text) || String.IsNullOrEmpty(txtLName.Text) || String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPhone.Text) || ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Complete all the required fields!");
                return;

            }
            else
            {
                cmd = new SqlCommand("Insert into StudentTable values (@Student_No,@LName,@FName,@Age,@Address,@Phone,@Course)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();
                ClearTextbox();
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            txtAge.MaxLength = 2;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtStudentID.MaxLength = 10;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.MaxLength = 15;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            txtLName.MaxLength = 20;
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            txtFName.MaxLength = 30;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.MaxLength = 50;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStudentID.Text) || String.IsNullOrEmpty(txtLName.Text) || String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrEmpty(txtAge.Text) || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPhone.Text) || ComboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Complete all the required fields!");
                return;

            }
            else
            {
                cmd = new SqlCommand("Update StudentTable set Student_No = @Student_No,LastName = @LName,FirstName = @FName,Age = @Age," + "Address = @Address,Contact = @Phone,Course = @Course where Student_No = @Student_No", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();
                ClearTextbox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete from StudentTable where Student_No = @Student_No", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            loadData();
            ClearTextbox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from StudentTable order by LastName asc", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from StudentTable where Student_No Like @search + '%' or LastName Like @search + '%' or FirstName Like @search + '%' or " 
                + "Age Like @search +'%' or Address Like @search + '%' or Contact Like @search + '%' or Course Like @search + '%'", con);
            cmd.Parameters.AddWithValue("search", txtSearch.Text);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
