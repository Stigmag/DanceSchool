namespace Dance_school.ButtonsForms
{
    partial class ChangePrice
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
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.PriceTbx = new System.Windows.Forms.MaskedTextBox();
            this.dance_schoolDataSet6 = new Dance_school.dance_schoolDataSet6();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Dance_school.dance_schoolDataSet6TableAdapters.CourseTableAdapter();
            this.CourseList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(382, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 15;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ChangeBtn.Location = new System.Drawing.Point(46, 156);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(299, 33);
            this.ChangeBtn.TabIndex = 29;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PriceLbl.Location = new System.Drawing.Point(43, 117);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 17);
            this.PriceLbl.TabIndex = 35;
            this.PriceLbl.Text = "Price:";
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CourseLbl.Location = new System.Drawing.Point(43, 53);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(57, 17);
            this.CourseLbl.TabIndex = 32;
            this.CourseLbl.Text = "Course:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CancelBtn.Location = new System.Drawing.Point(242, 211);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.OKBtn.Location = new System.Drawing.Point(37, 211);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 30;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // PriceTbx
            // 
            this.PriceTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.PriceTbx.BeepOnError = true;
            this.PriceTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.PriceTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PriceTbx.Location = new System.Drawing.Point(140, 110);
            this.PriceTbx.Name = "PriceTbx";
            this.PriceTbx.Size = new System.Drawing.Size(205, 28);
            this.PriceTbx.TabIndex = 36;
            this.PriceTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTbx_KeyPress);
            // 
            // dance_schoolDataSet6
            // 
            this.dance_schoolDataSet6.DataSetName = "dance_schoolDataSet6";
            this.dance_schoolDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dance_schoolDataSet6;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // CourseList
            // 
            this.CourseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.CourseList.DataSource = this.courseBindingSource;
            this.CourseList.DisplayMember = "name";
            this.CourseList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.CourseList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CourseList.FormattingEnabled = true;
            this.CourseList.ItemHeight = 20;
            this.CourseList.Location = new System.Drawing.Point(140, 41);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(205, 44);
            this.CourseList.TabIndex = 37;
            // 
            // ChangePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(413, 256);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.PriceTbx);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePrice";
            this.Load += new System.EventHandler(this.ChangePrice_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePrice_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePrice_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePrice_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.MaskedTextBox PriceTbx;
        private dance_schoolDataSet6 dance_schoolDataSet6;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dance_schoolDataSet6TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ListBox CourseList;
    }
}