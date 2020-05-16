namespace Dance_school.ButtonsForms
{
    partial class AddAccountToGroup
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseLbl = new System.Windows.Forms.Label();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet2 = new Dance_school.dance_schoolDataSet2();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet3 = new Dance_school.dance_schoolDataSet3();
            this.studentTableAdapter = new Dance_school.dance_schoolDataSet2TableAdapters.StudentTableAdapter();
            this.groupTableAdapter = new Dance_school.dance_schoolDataSet3TableAdapters.GroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(495, 349);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AddBtn.Location = new System.Drawing.Point(168, 349);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 33);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(771, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 15;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ClientList.DataSource = this.studentBindingSource;
            this.ClientList.DisplayMember = "name";
            this.ClientList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.ClientList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 20;
            this.ClientList.Location = new System.Drawing.Point(32, 30);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(314, 264);
            this.ClientList.TabIndex = 18;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dance_schoolDataSet2;
            // 
            // dance_schoolDataSet2
            // 
            this.dance_schoolDataSet2.DataSetName = "dance_schoolDataSet2";
            this.dance_schoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupList
            // 
            this.GroupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.GroupList.DataSource = this.groupBindingSource;
            this.GroupList.DisplayMember = "name";
            this.GroupList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.GroupList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.GroupList.FormattingEnabled = true;
            this.GroupList.ItemHeight = 20;
            this.GroupList.Location = new System.Drawing.Point(416, 30);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(314, 264);
            this.GroupList.TabIndex = 19;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.dance_schoolDataSet3;
            // 
            // dance_schoolDataSet3
            // 
            this.dance_schoolDataSet3.DataSetName = "dance_schoolDataSet3";
            this.dance_schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // AddAccountToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.CloseLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccountToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccountToGroup";
            this.Load += new System.EventHandler(this.AddAccountToGroup_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddAccountToGroup_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddAccountToGroup_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddAccountToGroup_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.ListBox GroupList;
        private dance_schoolDataSet2 dance_schoolDataSet2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dance_schoolDataSet2TableAdapters.StudentTableAdapter studentTableAdapter;
        private dance_schoolDataSet3 dance_schoolDataSet3;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private dance_schoolDataSet3TableAdapters.GroupTableAdapter groupTableAdapter;
    }
}