namespace Dance_school.ButtonsForms
{
    partial class ViewAllCoursePrices
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
            this.CourseLbl = new System.Windows.Forms.Label();
            this.OKBtn = new System.Windows.Forms.Button();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PriceTbx = new System.Windows.Forms.MaskedTextBox();
            this.dance_schoolDataSet15 = new Dance_school.dance_schoolDataSet15();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Dance_school.dance_schoolDataSet15TableAdapters.CourseTableAdapter();
            this.CourseList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(440, 9);
            this.CloseLbl.Name = "CloseLbl";
            this.CloseLbl.Size = new System.Drawing.Size(17, 17);
            this.CloseLbl.TabIndex = 16;
            this.CloseLbl.Text = "X";
            this.CloseLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CourseLbl.Location = new System.Drawing.Point(36, 57);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(57, 17);
            this.CourseLbl.TabIndex = 19;
            this.CourseLbl.Text = "Course:";
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.OKBtn.Location = new System.Drawing.Point(177, 225);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 17;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PriceLbl.Location = new System.Drawing.Point(49, 160);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(44, 17);
            this.PriceLbl.TabIndex = 22;
            this.PriceLbl.Text = "Price:";
            // 
            // PriceTbx
            // 
            this.PriceTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.PriceTbx.BeepOnError = true;
            this.PriceTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.PriceTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PriceTbx.Location = new System.Drawing.Point(146, 149);
            this.PriceTbx.Mask = "0000.00";
            this.PriceTbx.Name = "PriceTbx";
            this.PriceTbx.Size = new System.Drawing.Size(205, 28);
            this.PriceTbx.TabIndex = 23;
            // 
            // dance_schoolDataSet15
            // 
            this.dance_schoolDataSet15.DataSetName = "dance_schoolDataSet15";
            this.dance_schoolDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dance_schoolDataSet15;
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
            this.CourseList.Location = new System.Drawing.Point(146, 57);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(205, 24);
            this.CourseList.TabIndex = 24;
            this.CourseList.SelectedIndexChanged += new System.EventHandler(this.CourseList_SelectedIndexChanged);
            // 
            // ViewAllCoursePrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(469, 295);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.PriceTbx);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllCoursePrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllCoursePrices";
            this.Load += new System.EventHandler(this.ViewAllCoursePrices_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewAllCoursePrices_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewAllCoursePrices_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewAllCoursePrices_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.MaskedTextBox PriceTbx;
        private dance_schoolDataSet15 dance_schoolDataSet15;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dance_schoolDataSet15TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ListBox CourseList;
    }
}