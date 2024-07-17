namespace GUI
{
    partial class ProjectAdmin
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
            this.listViewProject = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_create_project = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1_update = new System.Windows.Forms.Panel();
            this.labelendProject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxProjectEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreateBtnProject = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.textboxIDproject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxStartProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDescProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNameProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.LSidProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.ListIDemp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProject
            // 
            this.listViewProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(6, 219);
            this.listViewProject.Margin = new System.Windows.Forms.Padding(1);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(866, 327);
            this.listViewProject.TabIndex = 5;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            this.listViewProject.SelectedIndexChanged += new System.EventHandler(this.listViewProject_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên dự án";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày bắt đầu";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày bắt đầu";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày kết thúc";
            this.columnHeader5.Width = 150;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(6, 175);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(260, 31);
            this.guna2TextBox1.TabIndex = 9;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::GUI.Properties.Resources.icons8_search_50;
            this.guna2Button4.Location = new System.Drawing.Point(274, 175);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(89, 31);
            this.guna2Button4.TabIndex = 10;
            this.guna2Button4.Text = "Tìm kiếm";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(571, 175);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(57, 31);
            this.guna2Button3.TabIndex = 13;
            this.guna2Button3.Text = "Xóa";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(491, 175);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(63, 31);
            this.guna2Button2.TabIndex = 12;
            this.guna2Button2.Text = "Sửa";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_create_project
            // 
            this.btn_create_project.BorderRadius = 8;
            this.btn_create_project.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_create_project.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_create_project.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create_project.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_create_project.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_create_project.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_create_project.ForeColor = System.Drawing.Color.White;
            this.btn_create_project.Location = new System.Drawing.Point(386, 175);
            this.btn_create_project.Margin = new System.Windows.Forms.Padding(1);
            this.btn_create_project.Name = "btn_create_project";
            this.btn_create_project.Size = new System.Drawing.Size(85, 31);
            this.btn_create_project.TabIndex = 11;
            this.btn_create_project.Text = "Tạo Dự Án";
            this.btn_create_project.Click += new System.EventHandler(this.btn_create_project_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(782, 175);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(87, 31);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Làm mới";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // panel1_update
            // 
            this.panel1_update.Controls.Add(this.labelendProject);
            this.panel1_update.Controls.Add(this.textBoxProjectEnd);
            this.panel1_update.Controls.Add(this.guna2Button7);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel5);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel4);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel3);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel2);
            this.panel1_update.Controls.Add(this.CreateBtnProject);
            this.panel1_update.Controls.Add(this.guna2Button5);
            this.panel1_update.Controls.Add(this.textboxIDproject);
            this.panel1_update.Controls.Add(this.TextBoxStartProject);
            this.panel1_update.Controls.Add(this.TextBoxDescProject);
            this.panel1_update.Controls.Add(this.TextBoxNameProject);
            this.panel1_update.Location = new System.Drawing.Point(309, 219);
            this.panel1_update.Margin = new System.Windows.Forms.Padding(1);
            this.panel1_update.Name = "panel1_update";
            this.panel1_update.Size = new System.Drawing.Size(255, 243);
            this.panel1_update.TabIndex = 15;
            this.panel1_update.Visible = false;
            this.panel1_update.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_update_Paint);
            // 
            // labelendProject
            // 
            this.labelendProject.BackColor = System.Drawing.Color.Transparent;
            this.labelendProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendProject.Location = new System.Drawing.Point(5, 177);
            this.labelendProject.Margin = new System.Windows.Forms.Padding(1);
            this.labelendProject.Name = "labelendProject";
            this.labelendProject.Size = new System.Drawing.Size(89, 19);
            this.labelendProject.TabIndex = 12;
            this.labelendProject.Text = "Ngày kết thúc";
            // 
            // textBoxProjectEnd
            // 
            this.textBoxProjectEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxProjectEnd.DefaultText = "";
            this.textBoxProjectEnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxProjectEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxProjectEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxProjectEnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxProjectEnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxProjectEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxProjectEnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxProjectEnd.Location = new System.Drawing.Point(93, 172);
            this.textBoxProjectEnd.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxProjectEnd.Name = "textBoxProjectEnd";
            this.textBoxProjectEnd.PasswordChar = '\0';
            this.textBoxProjectEnd.PlaceholderText = "";
            this.textBoxProjectEnd.SelectedText = "";
            this.textBoxProjectEnd.Size = new System.Drawing.Size(145, 24);
            this.textBoxProjectEnd.TabIndex = 11;
            // 
            // guna2Button7
            // 
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::GUI.Properties.Resources.icons8_forward_501;
            this.guna2Button7.Location = new System.Drawing.Point(223, 1);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(31, 22);
            this.guna2Button7.TabIndex = 10;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(5, 138);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(86, 19);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Ngày bắt đầu";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(5, 96);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(39, 19);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Mô tả";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(5, 65);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(64, 19);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Tên dự án";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(5, 29);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 19);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "ID dự án";
            // 
            // CreateBtnProject
            // 
            this.CreateBtnProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtnProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtnProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtnProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtnProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateBtnProject.ForeColor = System.Drawing.Color.White;
            this.CreateBtnProject.Location = new System.Drawing.Point(119, 207);
            this.CreateBtnProject.Margin = new System.Windows.Forms.Padding(1);
            this.CreateBtnProject.Name = "CreateBtnProject";
            this.CreateBtnProject.Size = new System.Drawing.Size(53, 19);
            this.CreateBtnProject.TabIndex = 5;
            this.CreateBtnProject.Text = "Tạo";
            this.CreateBtnProject.Click += new System.EventHandler(this.CreateBtnProject_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(184, 207);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(1);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(54, 19);
            this.guna2Button5.TabIndex = 4;
            this.guna2Button5.Text = "Sửa";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click_1);
            // 
            // textboxIDproject
            // 
            this.textboxIDproject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxIDproject.DefaultText = "";
            this.textboxIDproject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxIDproject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxIDproject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxIDproject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxIDproject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxIDproject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxIDproject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxIDproject.Location = new System.Drawing.Point(71, 24);
            this.textboxIDproject.Margin = new System.Windows.Forms.Padding(1);
            this.textboxIDproject.Name = "textboxIDproject";
            this.textboxIDproject.PasswordChar = '\0';
            this.textboxIDproject.PlaceholderText = "";
            this.textboxIDproject.SelectedText = "";
            this.textboxIDproject.Size = new System.Drawing.Size(167, 24);
            this.textboxIDproject.TabIndex = 3;
            // 
            // TextBoxStartProject
            // 
            this.TextBoxStartProject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxStartProject.DefaultText = "";
            this.TextBoxStartProject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxStartProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxStartProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxStartProject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxStartProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxStartProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxStartProject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxStartProject.Location = new System.Drawing.Point(93, 133);
            this.TextBoxStartProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxStartProject.Name = "TextBoxStartProject";
            this.TextBoxStartProject.PasswordChar = '\0';
            this.TextBoxStartProject.PlaceholderText = "";
            this.TextBoxStartProject.SelectedText = "";
            this.TextBoxStartProject.Size = new System.Drawing.Size(145, 24);
            this.TextBoxStartProject.TabIndex = 2;
            // 
            // TextBoxDescProject
            // 
            this.TextBoxDescProject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescProject.DefaultText = "";
            this.TextBoxDescProject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDescProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDescProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescProject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDescProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescProject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDescProject.Location = new System.Drawing.Point(71, 96);
            this.TextBoxDescProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxDescProject.Name = "TextBoxDescProject";
            this.TextBoxDescProject.PasswordChar = '\0';
            this.TextBoxDescProject.PlaceholderText = "";
            this.TextBoxDescProject.SelectedText = "";
            this.TextBoxDescProject.Size = new System.Drawing.Size(167, 24);
            this.TextBoxDescProject.TabIndex = 1;
            // 
            // TextBoxNameProject
            // 
            this.TextBoxNameProject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNameProject.DefaultText = "";
            this.TextBoxNameProject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNameProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNameProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNameProject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNameProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNameProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNameProject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNameProject.Location = new System.Drawing.Point(71, 60);
            this.TextBoxNameProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxNameProject.Name = "TextBoxNameProject";
            this.TextBoxNameProject.PasswordChar = '\0';
            this.TextBoxNameProject.PlaceholderText = "";
            this.TextBoxNameProject.SelectedText = "";
            this.TextBoxNameProject.Size = new System.Drawing.Size(167, 24);
            this.TextBoxNameProject.TabIndex = 0;
            // 
            // LSidProject
            // 
            this.LSidProject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LSidProject.DefaultText = "";
            this.LSidProject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LSidProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LSidProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LSidProject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LSidProject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LSidProject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LSidProject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LSidProject.Location = new System.Drawing.Point(387, 12);
            this.LSidProject.Name = "LSidProject";
            this.LSidProject.PasswordChar = '\0';
            this.LSidProject.PlaceholderText = "";
            this.LSidProject.SelectedText = "";
            this.LSidProject.Size = new System.Drawing.Size(177, 36);
            this.LSidProject.TabIndex = 16;
            // 
            // ListIDemp
            // 
            this.ListIDemp.BackColor = System.Drawing.Color.Transparent;
            this.ListIDemp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListIDemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListIDemp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ListIDemp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ListIDemp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListIDemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ListIDemp.ItemHeight = 30;
            this.ListIDemp.Location = new System.Drawing.Point(387, 69);
            this.ListIDemp.Name = "ListIDemp";
            this.ListIDemp.Size = new System.Drawing.Size(175, 36);
            this.ListIDemp.TabIndex = 17;
            this.ListIDemp.SelectedIndexChanged += new System.EventHandler(this.ListIDemp_SelectedIndexChanged);
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(598, 69);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(59, 36);
            this.guna2Button6.TabIndex = 18;
            this.guna2Button6.Text = "Thêm";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // ProjectAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 554);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.ListIDemp);
            this.Controls.Add(this.LSidProject);
            this.Controls.Add(this.panel1_update);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btn_create_project);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.listViewProject);
            this.Name = "ProjectAdmin";
            this.Text = "ProjectAdmin";
            this.Load += new System.EventHandler(this.ProjectAdmin_Load);
            this.panel1_update.ResumeLayout(false);
            this.panel1_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_create_project;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1_update;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelendProject;
        private Guna.UI2.WinForms.Guna2TextBox textBoxProjectEnd;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button CreateBtnProject;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2TextBox textboxIDproject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxStartProject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDescProject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNameProject;
        private Guna.UI2.WinForms.Guna2TextBox LSidProject;
        private Guna.UI2.WinForms.Guna2ComboBox ListIDemp;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
    }
}