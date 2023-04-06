using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
            this.CenterToScreen();
            ComboBox1.SelectedIndex = 0;
            lblCourse.Visible = false;
            ComboBox1.Visible = false;
            reportViewer1.LocalReport.DataSources.Clear();

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
            reportViewer1.LocalReport.DataSources.Clear();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ViewReports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
