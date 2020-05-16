namespace Dance_school
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.LGTbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.CorseList = new System.Windows.Forms.ListBox();
            this.CPbtn = new System.Windows.Forms.Button();
            this.CSbtn = new System.Windows.Forms.Button();
            this.HallList = new System.Windows.Forms.ListBox();
            this.dance_schoolDataSet16 = new Dance_school.dance_schoolDataSet16();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Dance_school.dance_schoolDataSet16TableAdapters.CourseTableAdapter();
            this.dance_schoolDataSet17 = new Dance_school.dance_schoolDataSet17();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new Dance_school.dance_schoolDataSet17TableAdapters.AccountingTableAdapter();
            this.dance_schoolDataSet18 = new Dance_school.dance_schoolDataSet18();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new Dance_school.dance_schoolDataSet18TableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.ForeColor = System.Drawing.Color.White;
            this.PhoneLbl.Location = new System.Drawing.Point(41, 395);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(61, 19);
            this.PhoneLbl.TabIndex = 28;
            this.PhoneLbl.Text = "Phone:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.ForeColor = System.Drawing.Color.White;
            this.EmailLbl.Location = new System.Drawing.Point(41, 354);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(54, 19);
            this.EmailLbl.TabIndex = 27;
            this.EmailLbl.Text = "Email:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(41, 311);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(56, 19);
            this.NameLbl.TabIndex = 26;
            this.NameLbl.Text = "Name:";
            // 
            // AvatarBox
            // 
            this.AvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarBox.Image")));
            this.AvatarBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarBox.InitialImage")));
            this.AvatarBox.Location = new System.Drawing.Point(41, 48);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(230, 230);
            this.AvatarBox.TabIndex = 25;
            this.AvatarBox.TabStop = false;
            // 
            // LGTbtn
            // 
            this.LGTbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.LGTbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LGTbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LGTbtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGTbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LGTbtn.Location = new System.Drawing.Point(41, 436);
            this.LGTbtn.Name = "LGTbtn";
            this.LGTbtn.Size = new System.Drawing.Size(230, 39);
            this.LGTbtn.TabIndex = 24;
            this.LGTbtn.Text = "Logout";
            this.LGTbtn.UseVisualStyleBackColor = false;
            this.LGTbtn.Click += new System.EventHandler(this.LGTbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(928, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "_";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelClose.Location = new System.Drawing.Point(952, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(20, 19);
            this.labelClose.TabIndex = 29;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            this.labelClose.MouseHover += new System.EventHandler(this.labelClose_MouseHover);
            // 
            // CorseList
            // 
            this.CorseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CorseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorseList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CorseList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CorseList.FormattingEnabled = true;
            this.CorseList.ItemHeight = 19;
            this.CorseList.Location = new System.Drawing.Point(537, 48);
            this.CorseList.Name = "CorseList";
            this.CorseList.Size = new System.Drawing.Size(419, 209);
            this.CorseList.TabIndex = 31;
            // 
            // CPbtn
            // 
            this.CPbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CPbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPbtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CPbtn.Location = new System.Drawing.Point(312, 95);
            this.CPbtn.Name = "CPbtn";
            this.CPbtn.Size = new System.Drawing.Size(174, 39);
            this.CPbtn.TabIndex = 32;
            this.CPbtn.Text = "Change price";
            this.CPbtn.UseVisualStyleBackColor = false;
            this.CPbtn.Click += new System.EventHandler(this.CPbtn_Click);
            // 
            // CSbtn
            // 
            this.CSbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CSbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CSbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSbtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CSbtn.Location = new System.Drawing.Point(312, 436);
            this.CSbtn.Name = "CSbtn";
            this.CSbtn.Size = new System.Drawing.Size(174, 39);
            this.CSbtn.TabIndex = 34;
            this.CSbtn.Text = "Change status";
            this.CSbtn.UseVisualStyleBackColor = false;
            this.CSbtn.Click += new System.EventHandler(this.CSbtn_Click);
            // 
            // HallList
            // 
            this.HallList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.HallList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HallList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HallList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.HallList.FormattingEnabled = true;
            this.HallList.ItemHeight = 19;
            this.HallList.Location = new System.Drawing.Point(537, 292);
            this.HallList.Name = "HallList";
            this.HallList.Size = new System.Drawing.Size(419, 209);
            this.HallList.TabIndex = 33;
            // 
            // dance_schoolDataSet16
            // 
            this.dance_schoolDataSet16.DataSetName = "dance_schoolDataSet16";
            this.dance_schoolDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dance_schoolDataSet16;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // dance_schoolDataSet17
            // 
            this.dance_schoolDataSet17.DataSetName = "dance_schoolDataSet17";
            this.dance_schoolDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "Accounting";
            this.accountingBindingSource.DataSource = this.dance_schoolDataSet17;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // dance_schoolDataSet18
            // 
            this.dance_schoolDataSet18.DataSetName = "dance_schoolDataSet18";
            this.dance_schoolDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.dance_schoolDataSet18;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.CSbtn);
            this.Controls.Add(this.HallList);
            this.Controls.Add(this.CPbtn);
            this.Controls.Add(this.CorseList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.LGTbtn);
            this.Font = new System.Drawing.Font("Arial", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ManagerForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ManagerForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ManagerForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Button LGTbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ListBox CorseList;
        private System.Windows.Forms.Button CPbtn;
        private System.Windows.Forms.Button CSbtn;
        private System.Windows.Forms.ListBox HallList;
        private dance_schoolDataSet16 dance_schoolDataSet16;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dance_schoolDataSet16TableAdapters.CourseTableAdapter courseTableAdapter;
        private dance_schoolDataSet17 dance_schoolDataSet17;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private dance_schoolDataSet17TableAdapters.AccountingTableAdapter accountingTableAdapter;
        private dance_schoolDataSet18 dance_schoolDataSet18;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private dance_schoolDataSet18TableAdapters.CourseTableAdapter courseTableAdapter1;
    }
}