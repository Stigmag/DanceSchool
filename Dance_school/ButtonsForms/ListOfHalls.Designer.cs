namespace Dance_school.ButtonsForms
{
    partial class ListOfHalls
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
            this.HallsLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.StatusList = new System.Windows.Forms.ListBox();
            this.ListRooms = new System.Windows.Forms.ListBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet14 = new Dance_school.dance_schoolDataSet14();
            this.roomTableAdapter = new Dance_school.dance_schoolDataSet14TableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(426, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 16;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // HallsLbl
            // 
            this.HallsLbl.AutoSize = true;
            this.HallsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HallsLbl.Location = new System.Drawing.Point(39, 66);
            this.HallsLbl.Name = "HallsLbl";
            this.HallsLbl.Size = new System.Drawing.Size(36, 17);
            this.HallsLbl.TabIndex = 17;
            this.HallsLbl.Text = "Hall:";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StatusLbl.Location = new System.Drawing.Point(39, 159);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(52, 17);
            this.StatusLbl.TabIndex = 22;
            this.StatusLbl.Text = "Status:";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ChangeBtn.Location = new System.Drawing.Point(320, 248);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(103, 33);
            this.ChangeBtn.TabIndex = 20;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.OKBtn.Location = new System.Drawing.Point(28, 248);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 19;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusList
            // 
            this.StatusList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.StatusList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.StatusList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.StatusList.FormattingEnabled = true;
            this.StatusList.ItemHeight = 20;
            this.StatusList.Location = new System.Drawing.Point(174, 152);
            this.StatusList.Name = "StatusList";
            this.StatusList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StatusList.Size = new System.Drawing.Size(205, 44);
            this.StatusList.TabIndex = 23;
            // 
            // ListRooms
            // 
            this.ListRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ListRooms.DataSource = this.roomBindingSource;
            this.ListRooms.DisplayMember = "name";
            this.ListRooms.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.ListRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ListRooms.FormattingEnabled = true;
            this.ListRooms.ItemHeight = 20;
            this.ListRooms.Location = new System.Drawing.Point(174, 66);
            this.ListRooms.Name = "ListRooms";
            this.ListRooms.Size = new System.Drawing.Size(205, 24);
            this.ListRooms.TabIndex = 24;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dance_schoolDataSet14;
            // 
            // dance_schoolDataSet14
            // 
            this.dance_schoolDataSet14.DataSetName = "dance_schoolDataSet14";
            this.dance_schoolDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // ListOfHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(455, 315);
            this.Controls.Add(this.ListRooms);
            this.Controls.Add(this.StatusList);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.HallsLbl);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfHalls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfHalls";
            this.Load += new System.EventHandler(this.ListOfHalls_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListOfHalls_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListOfHalls_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListOfHalls_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Label HallsLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.ListBox StatusList;
        private System.Windows.Forms.ListBox ListRooms;
        private dance_schoolDataSet14 dance_schoolDataSet14;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private dance_schoolDataSet14TableAdapters.RoomTableAdapter roomTableAdapter;
    }
}