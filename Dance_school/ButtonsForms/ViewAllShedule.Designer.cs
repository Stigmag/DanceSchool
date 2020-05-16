namespace Dance_school.ButtonsForms
{
    partial class ViewAllShedule
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
            this.ScheduleList = new System.Windows.Forms.ListBox();
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
            this.CloseLbl.Location = new System.Drawing.Point(968, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 16;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // ScheduleList
            // 
            this.ScheduleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ScheduleList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.ScheduleList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ScheduleList.FormattingEnabled = true;
            this.ScheduleList.ItemHeight = 20;
            this.ScheduleList.Location = new System.Drawing.Point(82, 45);
            this.ScheduleList.Name = "ScheduleList";
            this.ScheduleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ScheduleList.Size = new System.Drawing.Size(856, 424);
            this.ScheduleList.TabIndex = 19;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(854, 499);
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
            this.OKBtn.Location = new System.Drawing.Point(82, 499);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 17;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ViewAllShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(997, 557);
            this.Controls.Add(this.ScheduleList);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllShedule";
            this.Text = "ViewAllShedule";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewAllShedule_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewAllShedule_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewAllShedule_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.ListBox ScheduleList;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
    }
}