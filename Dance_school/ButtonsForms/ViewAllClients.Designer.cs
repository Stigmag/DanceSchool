namespace Dance_school.ButtonsForms
{
    partial class ViewAllClients
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
            this.CloseLbl = new System.Windows.Forms.Label();
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.StudentsLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(1124, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 15;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // StudentsList
            // 
            this.StudentsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.StudentsList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.StudentsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.ItemHeight = 20;
            this.StudentsList.Location = new System.Drawing.Point(119, 38);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.StudentsList.Size = new System.Drawing.Size(992, 564);
            this.StudentsList.TabIndex = 19;
            // 
            // StudentsLbl
            // 
            this.StudentsLbl.AutoSize = true;
            this.StudentsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsLbl.Location = new System.Drawing.Point(23, 38);
            this.StudentsLbl.Name = "StudentsLbl";
            this.StudentsLbl.Size = new System.Drawing.Size(68, 17);
            this.StudentsLbl.TabIndex = 18;
            this.StudentsLbl.Text = "Students:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(1008, 625);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 17;
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
            this.OKBtn.Location = new System.Drawing.Point(170, 625);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 16;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ViewAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1153, 679);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.StudentsLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllClients";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewAllClients_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewAllClients_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewAllClients_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.Label StudentsLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
    }
}