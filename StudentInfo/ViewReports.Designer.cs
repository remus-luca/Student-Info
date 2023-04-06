
namespace StudentInfo
{
    partial class ViewReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCourse = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SummaryList = new StudentInfo.SummaryList();
            this.StudentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentTableTableAdapter = new StudentInfo.SummaryListTableAdapters.StudentTableTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Report Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 50);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(139, 44);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 48);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.byCourseToolStripMenuItem,
            this.byAgeToolStripMenuItem});
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            this.viewReportsToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.viewReportsToolStripMenuItem.Text = "View Reports";
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(256, 48);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // byCourseToolStripMenuItem
            // 
            this.byCourseToolStripMenuItem.Name = "byCourseToolStripMenuItem";
            this.byCourseToolStripMenuItem.Size = new System.Drawing.Size(256, 48);
            this.byCourseToolStripMenuItem.Text = "By Course";
            // 
            // byAgeToolStripMenuItem
            // 
            this.byAgeToolStripMenuItem.Name = "byAgeToolStripMenuItem";
            this.byAgeToolStripMenuItem.Size = new System.Drawing.Size(256, 48);
            this.byAgeToolStripMenuItem.Text = "By Age";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCourse.Location = new System.Drawing.Point(52, 151);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(120, 37);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Course";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Select your Course",
            "Intro IT",
            "Software Testing",
            "Testing Automation",
            "JavaScript",
            "Php",
            "C#",
            "Database SQL",
            "Python",
            "Java"});
            this.ComboBox1.Location = new System.Drawing.Point(207, 151);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(296, 41);
            this.ComboBox1.TabIndex = 18;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "SUMMARYLIST";
            reportDataSource2.Value = this.StudentTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentInfo.Summary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 230);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1093, 426);
            this.reportViewer1.TabIndex = 19;
            // 
            // SummaryList
            // 
            this.SummaryList.DataSetName = "SummaryList";
            this.SummaryList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentTableBindingSource
            // 
            this.StudentTableBindingSource.DataMember = "StudentTable";
            this.StudentTableBindingSource.DataSource = this.SummaryList;
            // 
            // StudentTableTableAdapter
            // 
            this.StudentTableTableAdapter.ClearBeforeFill = true;
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.Load += new System.EventHandler(this.ViewReports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byAgeToolStripMenuItem;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox ComboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentTableBindingSource;
        private StudentInfo.SummaryList SummaryList;
        private StudentInfo.SummaryListTableAdapters.StudentTableTableAdapter StudentTableTableAdapter;
    }
}