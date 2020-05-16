namespace Dance_school.ButtonsForms
{
    partial class ViewAllGroups
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
            this.OKBtn = new System.Windows.Forms.Button();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.StudentsLbl = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.dance_schoolDataSet1 = new Dance_school.dance_schoolDataSet1();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new Dance_school.dance_schoolDataSet1TableAdapters.GroupTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.danceschoolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet = new Dance_school.dance_schoolDataSet();
            this.groupTableAdapter1 = new Dance_school.dance_schoolDataSetTableAdapters.GroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceschoolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(428, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 16;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(304, 332);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.OKBtn.Location = new System.Drawing.Point(44, 332);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 17;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupLbl.Location = new System.Drawing.Point(60, 52);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(52, 17);
            this.GroupLbl.TabIndex = 20;
            this.GroupLbl.Text = "Group:";
            // 
            // StudentsLbl
            // 
            this.StudentsLbl.AutoSize = true;
            this.StudentsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsLbl.Location = new System.Drawing.Point(60, 105);
            this.StudentsLbl.Name = "StudentsLbl";
            this.StudentsLbl.Size = new System.Drawing.Size(68, 17);
            this.StudentsLbl.TabIndex = 19;
            this.StudentsLbl.Text = "Students:";
            // 
            // StudentsList
            // 
            this.StudentsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.StudentsList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.StudentsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.ItemHeight = 20;
            this.StudentsList.Location = new System.Drawing.Point(162, 98);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StudentsList.Size = new System.Drawing.Size(205, 184);
            this.StudentsList.TabIndex = 22;
            // 
            // dance_schoolDataSet1
            // 
            this.dance_schoolDataSet1.DataSetName = "dance_schoolDataSet1";
            this.dance_schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.dance_schoolDataSet1;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.listBox1.DataSource = this.groupBindingSource1;
            this.listBox1.DisplayMember = "id";
            this.listBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(162, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 20);
            this.listBox1.TabIndex = 23;
            // 
            // groupBindingSource1
            // 
            this.groupBindingSource1.DataMember = "Group";
            this.groupBindingSource1.DataSource = this.danceschoolDataSetBindingSource;
            // 
            // danceschoolDataSetBindingSource
            // 
            this.danceschoolDataSetBindingSource.DataSource = this.dance_schoolDataSet;
            this.danceschoolDataSetBindingSource.Position = 0;
            // 
            // dance_schoolDataSet
            // 
            this.dance_schoolDataSet.DataSetName = "dance_schoolDataSet";
            this.dance_schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupTableAdapter1
            // 
            this.groupTableAdapter1.ClearBeforeFill = true;
            // 
            // ViewAllGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(457, 401);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.StudentsLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllGroups";
            this.Load += new System.EventHandler(this.ViewAllGroups_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewAllGroups_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewAllGroups_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewAllGroups_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danceschoolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Label StudentsLbl;
        private System.Windows.Forms.ListBox StudentsList;
        private dance_schoolDataSet1 dance_schoolDataSet1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private dance_schoolDataSet1TableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource danceschoolDataSetBindingSource;
        private dance_schoolDataSet dance_schoolDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource1;
        private dance_schoolDataSetTableAdapters.GroupTableAdapter groupTableAdapter1;
    }
}