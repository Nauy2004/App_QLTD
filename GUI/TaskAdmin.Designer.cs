namespace GUI
{
    partial class TaskAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sửa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1_update = new System.Windows.Forms.Panel();
            this.guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.IdTaskTextBox = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabelStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelendProject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxProjectEnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CreateBtnTask = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.textboxIDproject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxStartProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDescProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxNameProject = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ButtonADD = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxIDTask = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxIdEMP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonAddUserTask = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_delete_task = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTask,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Sửa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 451);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDTask
            // 
            this.IDTask.DataPropertyName = "TaskID";
            this.IDTask.HeaderText = "ID";
            this.IDTask.Name = "IDTask";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "TaskName";
            this.Column2.HeaderText = "Tên Công việc";
            this.Column2.Name = "Column2";
            this.Column2.Width = 94;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TaskDescription";
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DuaDate";
            this.Column4.HeaderText = "Ngày bắt đầu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Priority";
            this.Column6.HeaderText = "Đồ ưu tiên";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "EstimatedEffort";
            this.Column7.HeaderText = "Thời gian ước tính";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProjectID";
            this.Column8.HeaderText = "ID dự án";
            this.Column8.Name = "Column8";
            // 
            // Sửa
            // 
            this.Sửa.HeaderText = "";
            this.Sửa.Name = "Sửa";
            this.Sửa.ReadOnly = true;
            this.Sửa.Text = "Thêm";
            // 
            // panel1_update
            // 
            this.panel1_update.Controls.Add(this.guna2ButtonDelete);
            this.panel1_update.Controls.Add(this.IdTaskTextBox);
            this.panel1_update.Controls.Add(this.guna2TextBox2);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel1);
            this.panel1_update.Controls.Add(this.guna2TextBox1);
            this.panel1_update.Controls.Add(this.guna2HtmlLabelStatus);
            this.panel1_update.Controls.Add(this.guna2ComboBox1);
            this.panel1_update.Controls.Add(this.labelendProject);
            this.panel1_update.Controls.Add(this.textBoxProjectEnd);
            this.panel1_update.Controls.Add(this.guna2Button7);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel5);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel4);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel3);
            this.panel1_update.Controls.Add(this.guna2HtmlLabel2);
            this.panel1_update.Controls.Add(this.CreateBtnTask);
            this.panel1_update.Controls.Add(this.guna2ButtonUpdate);
            this.panel1_update.Controls.Add(this.textboxIDproject);
            this.panel1_update.Controls.Add(this.TextBoxStartProject);
            this.panel1_update.Controls.Add(this.TextBoxDescProject);
            this.panel1_update.Controls.Add(this.TextBoxNameProject);
            this.panel1_update.Location = new System.Drawing.Point(347, 162);
            this.panel1_update.Margin = new System.Windows.Forms.Padding(1);
            this.panel1_update.Name = "panel1_update";
            this.panel1_update.Size = new System.Drawing.Size(299, 445);
            this.panel1_update.TabIndex = 16;
            this.panel1_update.Visible = false;
            this.panel1_update.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_update_Paint);
            // 
            // guna2ButtonDelete
            // 
            this.guna2ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDelete.Location = new System.Drawing.Point(120, 401);
            this.guna2ButtonDelete.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ButtonDelete.Name = "guna2ButtonDelete";
            this.guna2ButtonDelete.Size = new System.Drawing.Size(54, 19);
            this.guna2ButtonDelete.TabIndex = 19;
            this.guna2ButtonDelete.Text = "Xóa";
            // 
            // IdTaskTextBox
            // 
            this.IdTaskTextBox.BackColor = System.Drawing.Color.Transparent;
            this.IdTaskTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTaskTextBox.Location = new System.Drawing.Point(23, 33);
            this.IdTaskTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.IdTaskTextBox.Name = "IdTaskTextBox";
            this.IdTaskTextBox.Size = new System.Drawing.Size(79, 19);
            this.IdTaskTextBox.TabIndex = 18;
            this.IdTaskTextBox.Text = "ID Công việc";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(21, 57);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(224, 24);
            this.guna2TextBox2.TabIndex = 17;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 282);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 19);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Ước tính";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(23, 303);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(123, 24);
            this.guna2TextBox1.TabIndex = 15;
            // 
            // guna2HtmlLabelStatus
            // 
            this.guna2HtmlLabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelStatus.Location = new System.Drawing.Point(155, 277);
            this.guna2HtmlLabelStatus.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabelStatus.Name = "guna2HtmlLabelStatus";
            this.guna2HtmlLabelStatus.Size = new System.Drawing.Size(67, 19);
            this.guna2HtmlLabelStatus.TabIndex = 14;
            this.guna2HtmlLabelStatus.Text = "Độ ưu tiên";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(21, 361);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(224, 36);
            this.guna2ComboBox1.TabIndex = 13;
            // 
            // labelendProject
            // 
            this.labelendProject.BackColor = System.Drawing.Color.Transparent;
            this.labelendProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendProject.Location = new System.Drawing.Point(23, 338);
            this.labelendProject.Margin = new System.Windows.Forms.Padding(1);
            this.labelendProject.Name = "labelendProject";
            this.labelendProject.Size = new System.Drawing.Size(68, 19);
            this.labelendProject.TabIndex = 12;
            this.labelendProject.Text = "Tình Trang";
            this.labelendProject.Click += new System.EventHandler(this.labelendProject_Click);
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
            this.textBoxProjectEnd.Location = new System.Drawing.Point(148, 303);
            this.textBoxProjectEnd.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxProjectEnd.Name = "textBoxProjectEnd";
            this.textBoxProjectEnd.PasswordChar = '\0';
            this.textBoxProjectEnd.PlaceholderText = "";
            this.textBoxProjectEnd.SelectedText = "";
            this.textBoxProjectEnd.Size = new System.Drawing.Size(97, 24);
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
            this.guna2Button7.Location = new System.Drawing.Point(261, 4);
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
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 224);
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
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 177);
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
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 130);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(86, 19);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Tên công việc";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 83);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 19);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "ID dự án";
            // 
            // CreateBtnTask
            // 
            this.CreateBtnTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtnTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtnTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtnTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtnTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateBtnTask.ForeColor = System.Drawing.Color.White;
            this.CreateBtnTask.Location = new System.Drawing.Point(21, 401);
            this.CreateBtnTask.Margin = new System.Windows.Forms.Padding(1);
            this.CreateBtnTask.Name = "CreateBtnTask";
            this.CreateBtnTask.Size = new System.Drawing.Size(53, 19);
            this.CreateBtnTask.TabIndex = 5;
            this.CreateBtnTask.Text = "Tạo";
            this.CreateBtnTask.Visible = false;
            this.CreateBtnTask.Click += new System.EventHandler(this.CreateBtnTask_Click);
            // 
            // guna2ButtonUpdate
            // 
            this.guna2ButtonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUpdate.Location = new System.Drawing.Point(191, 401);
            this.guna2ButtonUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ButtonUpdate.Name = "guna2ButtonUpdate";
            this.guna2ButtonUpdate.Size = new System.Drawing.Size(54, 19);
            this.guna2ButtonUpdate.TabIndex = 4;
            this.guna2ButtonUpdate.Text = "Sửa";
            this.guna2ButtonUpdate.Click += new System.EventHandler(this.guna2Button5_Click);
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
            this.textboxIDproject.Location = new System.Drawing.Point(21, 104);
            this.textboxIDproject.Margin = new System.Windows.Forms.Padding(1);
            this.textboxIDproject.Name = "textboxIDproject";
            this.textboxIDproject.PasswordChar = '\0';
            this.textboxIDproject.PlaceholderText = "";
            this.textboxIDproject.SelectedText = "";
            this.textboxIDproject.Size = new System.Drawing.Size(224, 24);
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
            this.TextBoxStartProject.Location = new System.Drawing.Point(21, 245);
            this.TextBoxStartProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxStartProject.Name = "TextBoxStartProject";
            this.TextBoxStartProject.PasswordChar = '\0';
            this.TextBoxStartProject.PlaceholderText = "";
            this.TextBoxStartProject.SelectedText = "";
            this.TextBoxStartProject.Size = new System.Drawing.Size(224, 24);
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
            this.TextBoxDescProject.Location = new System.Drawing.Point(21, 198);
            this.TextBoxDescProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxDescProject.Name = "TextBoxDescProject";
            this.TextBoxDescProject.PasswordChar = '\0';
            this.TextBoxDescProject.PlaceholderText = "";
            this.TextBoxDescProject.SelectedText = "";
            this.TextBoxDescProject.Size = new System.Drawing.Size(224, 24);
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
            this.TextBoxNameProject.Location = new System.Drawing.Point(21, 151);
            this.TextBoxNameProject.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxNameProject.Name = "TextBoxNameProject";
            this.TextBoxNameProject.PasswordChar = '\0';
            this.TextBoxNameProject.PlaceholderText = "";
            this.TextBoxNameProject.SelectedText = "";
            this.TextBoxNameProject.Size = new System.Drawing.Size(224, 24);
            this.TextBoxNameProject.TabIndex = 0;
            // 
            // guna2ButtonADD
            // 
            this.guna2ButtonADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonADD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonADD.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonADD.Location = new System.Drawing.Point(891, 590);
            this.guna2ButtonADD.Name = "guna2ButtonADD";
            this.guna2ButtonADD.Size = new System.Drawing.Size(111, 34);
            this.guna2ButtonADD.TabIndex = 17;
            this.guna2ButtonADD.Text = "Thêm công việc";
            this.guna2ButtonADD.Click += new System.EventHandler(this.guna2ButtonADD_Click);
            // 
            // ComboBoxIDTask
            // 
            this.ComboBoxIDTask.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxIDTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxIDTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIDTask.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxIDTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxIDTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxIDTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxIDTask.ItemHeight = 30;
            this.ComboBoxIDTask.Location = new System.Drawing.Point(650, 27);
            this.ComboBoxIDTask.Name = "ComboBoxIDTask";
            this.ComboBoxIDTask.Size = new System.Drawing.Size(140, 36);
            this.ComboBoxIDTask.TabIndex = 18;
            this.ComboBoxIDTask.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // ComboBoxIdEMP
            // 
            this.ComboBoxIdEMP.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxIdEMP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxIdEMP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIdEMP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxIdEMP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxIdEMP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxIdEMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxIdEMP.ItemHeight = 30;
            this.ComboBoxIdEMP.Location = new System.Drawing.Point(650, 90);
            this.ComboBoxIdEMP.Name = "ComboBoxIdEMP";
            this.ComboBoxIdEMP.Size = new System.Drawing.Size(140, 36);
            this.ComboBoxIdEMP.TabIndex = 19;
            // 
            // ButtonAddUserTask
            // 
            this.ButtonAddUserTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddUserTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddUserTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddUserTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddUserTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddUserTask.ForeColor = System.Drawing.Color.White;
            this.ButtonAddUserTask.Location = new System.Drawing.Point(852, 81);
            this.ButtonAddUserTask.Name = "ButtonAddUserTask";
            this.ButtonAddUserTask.Size = new System.Drawing.Size(67, 36);
            this.ButtonAddUserTask.TabIndex = 20;
            this.ButtonAddUserTask.Text = "Thêm";
            this.ButtonAddUserTask.Click += new System.EventHandler(this.ButtonAddUserTask_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(852, 27);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(150, 36);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Xem phân  công";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(650, 11);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(116, 15);
            this.guna2HtmlLabel6.TabIndex = 22;
            this.guna2HtmlLabel6.Text = "Danh sách id công việc";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(650, 74);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(119, 15);
            this.guna2HtmlLabel7.TabIndex = 23;
            this.guna2HtmlLabel7.Text = "Danh sách ID nhân viên";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(203, 32);
            this.guna2HtmlLabel8.TabIndex = 24;
            this.guna2HtmlLabel8.Text = "Danh sách công việc";
            // 
            // Btn_delete_task
            // 
            this.Btn_delete_task.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_delete_task.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_delete_task.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_delete_task.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_delete_task.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_delete_task.ForeColor = System.Drawing.Color.White;
            this.Btn_delete_task.Location = new System.Drawing.Point(935, 81);
            this.Btn_delete_task.Name = "Btn_delete_task";
            this.Btn_delete_task.Size = new System.Drawing.Size(67, 36);
            this.Btn_delete_task.TabIndex = 25;
            this.Btn_delete_task.Text = "Xóa";
            this.Btn_delete_task.Click += new System.EventHandler(this.Btn_delete_task_Click);
            // 
            // TaskAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 635);
            this.Controls.Add(this.Btn_delete_task);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ButtonAddUserTask);
            this.Controls.Add(this.ComboBoxIdEMP);
            this.Controls.Add(this.ComboBoxIDTask);
            this.Controls.Add(this.guna2ButtonADD);
            this.Controls.Add(this.panel1_update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TaskAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskAdmin";
            this.Load += new System.EventHandler(this.TaskAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1_update.ResumeLayout(false);
            this.panel1_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Sửa;
        private System.Windows.Forms.Panel panel1_update;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelendProject;
        private Guna.UI2.WinForms.Guna2TextBox textBoxProjectEnd;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button CreateBtnTask;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdate;
        private Guna.UI2.WinForms.Guna2TextBox textboxIDproject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxStartProject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDescProject;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNameProject;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel IdTaskTextBox;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDelete;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonADD;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxIDTask;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxIdEMP;
        private Guna.UI2.WinForms.Guna2Button ButtonAddUserTask;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button Btn_delete_task;
    }
}