namespace Dance_school.ButtonsForms
{
    partial class AddGroup
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
            this.CloseLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CourceLbl = new System.Windows.Forms.Label();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet5 = new Dance_school.dance_schoolDataSet5();
            this.dance_schoolDataSet4 = new Dance_school.dance_schoolDataSet4();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Dance_school.dance_schoolDataSet4TableAdapters.CourseTableAdapter();
            this.courseTableAdapter1 = new Dance_school.dance_schoolDataSet5TableAdapters.CourseTableAdapter();
            this.NameTbx = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(631, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 15;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(390, 272);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AddBtn.Location = new System.Drawing.Point(83, 272);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 33);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Location = new System.Drawing.Point(57, 45);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "Name:";
            // 
            // CourceLbl
            // 
            this.CourceLbl.AutoSize = true;
            this.CourceLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CourceLbl.Location = new System.Drawing.Point(49, 154);
            this.CourceLbl.Name = "CourceLbl";
            this.CourceLbl.Size = new System.Drawing.Size(57, 17);
            this.CourceLbl.TabIndex = 23;
            this.CourceLbl.Text = "Course:";
            // 
            // CourseList
            // 
            this.CourseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CourseList.DataSource = this.courseBindingSource1;
            this.CourseList.DisplayMember = "name";
            this.CourseList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.CourseList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CourseList.FormattingEnabled = true;
            this.CourseList.ItemHeight = 20;
            this.CourseList.Location = new System.Drawing.Point(204, 151);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(184, 20);
            this.CourseList.TabIndex = 32;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.dance_schoolDataSet5;
            // 
            // dance_schoolDataSet5
            // 
            this.dance_schoolDataSet5.DataSetName = "dance_schoolDataSet5";
            this.dance_schoolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dance_schoolDataSet4
            // 
            this.dance_schoolDataSet4.DataSetName = "dance_schoolDataSet4";
            this.dance_schoolDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dance_schoolDataSet4;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // NameTbx
            // 
            this.NameTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.NameTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.NameTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.NameTbx.Location = new System.Drawing.Point(204, 38);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(184, 28);
            this.NameTbx.TabIndex = 31;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(558, 336);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.CourceLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddGroup_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddGroup_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddGroup_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label CourceLbl;
        private System.Windows.Forms.ListBox CourseList;
        private dance_schoolDataSet4 dance_schoolDataSet4;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dance_schoolDataSet4TableAdapters.CourseTableAdapter courseTableAdapter;
        private dance_schoolDataSet5 dance_schoolDataSet5;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private dance_schoolDataSet5TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.MaskedTextBox NameTbx;
    }
}