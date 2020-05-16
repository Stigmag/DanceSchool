namespace Dance_school.ButtonsForms
{
    partial class AccountPermission
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
            this.StatusList = new System.Windows.Forms.ListBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.PhoneTbx = new System.Windows.Forms.MaskedTextBox();
            this.dance_schoolDataSet9 = new Dance_school.dance_schoolDataSet9();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Dance_school.dance_schoolDataSet9TableAdapters.StaffTableAdapter();
            this.listOfStaff = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(686, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 15;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // StatusList
            // 
            this.StatusList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.StatusList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.StatusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.StatusList.FormattingEnabled = true;
            this.StatusList.ItemHeight = 20;
            this.StatusList.Location = new System.Drawing.Point(433, 131);
            this.StatusList.Name = "StatusList";
            this.StatusList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StatusList.Size = new System.Drawing.Size(205, 64);
            this.StatusList.TabIndex = 25;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StatusLbl.Location = new System.Drawing.Point(354, 138);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(48, 17);
            this.StatusLbl.TabIndex = 24;
            this.StatusLbl.Text = "Staus:";
            // 
            // EmailTbx
            // 
            this.EmailTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.EmailTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.EmailTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.EmailTbx.Location = new System.Drawing.Point(138, 135);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(184, 28);
            this.EmailTbx.TabIndex = 21;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EmailLbl.Location = new System.Drawing.Point(36, 138);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(46, 17);
            this.EmailLbl.TabIndex = 20;
            this.EmailLbl.Text = "Email:";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneLbl.Location = new System.Drawing.Point(354, 39);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(53, 17);
            this.PhoneLbl.TabIndex = 19;
            this.PhoneLbl.Text = "Phone:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLbl.Location = new System.Drawing.Point(36, 39);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 18;
            this.NameLbl.Text = "Name:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(476, 209);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ChangeBtn.Location = new System.Drawing.Point(149, 209);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(103, 33);
            this.ChangeBtn.TabIndex = 16;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // PhoneTbx
            // 
            this.PhoneTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.PhoneTbx.BeepOnError = true;
            this.PhoneTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.PhoneTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PhoneTbx.Location = new System.Drawing.Point(433, 32);
            this.PhoneTbx.Mask = "(999) 000-0000";
            this.PhoneTbx.Name = "PhoneTbx";
            this.PhoneTbx.Size = new System.Drawing.Size(205, 28);
            this.PhoneTbx.TabIndex = 28;
            // 
            // dance_schoolDataSet9
            // 
            this.dance_schoolDataSet9.DataSetName = "dance_schoolDataSet9";
            this.dance_schoolDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dance_schoolDataSet9;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // listOfStaff
            // 
            this.listOfStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.listOfStaff.DataSource = this.staffBindingSource;
            this.listOfStaff.DisplayMember = "name";
            this.listOfStaff.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.listOfStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.listOfStaff.FormattingEnabled = true;
            this.listOfStaff.ItemHeight = 20;
            this.listOfStaff.Location = new System.Drawing.Point(132, 32);
            this.listOfStaff.Name = "listOfStaff";
            this.listOfStaff.Size = new System.Drawing.Size(190, 24);
            this.listOfStaff.TabIndex = 29;
            // 
            // AccountPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(715, 286);
            this.Controls.Add(this.listOfStaff);
            this.Controls.Add(this.PhoneTbx);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountPermission";
            this.Load += new System.EventHandler(this.AccountPermission_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AccountPermission_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AccountPermission_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AccountPermission_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.ListBox StatusList;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.MaskedTextBox PhoneTbx;
        private dance_schoolDataSet9 dance_schoolDataSet9;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private dance_schoolDataSet9TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.ListBox listOfStaff;
    }
}