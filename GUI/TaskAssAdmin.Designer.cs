namespace GUI
{
    partial class TaskAssAdmin
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
            this.listViewEmpTask = new System.Windows.Forms.ListView();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listViewEmpTask
            // 
            this.listViewEmpTask.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmpTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewEmpTask.HideSelection = false;
            this.listViewEmpTask.Location = new System.Drawing.Point(0, 0);
            this.listViewEmpTask.Name = "listViewEmpTask";
            this.listViewEmpTask.Size = new System.Drawing.Size(386, 625);
            this.listViewEmpTask.TabIndex = 0;
            this.listViewEmpTask.UseCompatibleStateImageBehavior = false;
            this.listViewEmpTask.View = System.Windows.Forms.View.Details;
            this.listViewEmpTask.SelectedIndexChanged += new System.EventHandler(this.listViewEmpTask_SelectedIndexChanged);
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBoxComment.Location = new System.Drawing.Point(520, 0);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(501, 625);
            this.richTextBoxComment.TabIndex = 1;
            this.richTextBoxComment.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID task";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name task";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name emp";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Role";
            this.columnHeader4.Width = 80;
            // 
            // timer1
            // 
            // 
            // TaskAssAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 625);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.listViewEmpTask);
            this.Name = "TaskAssAdmin";
            this.Text = "TaskAssAdmin";
            this.Load += new System.EventHandler(this.TaskAssAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmpTask;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Timer timer1;
    }
}