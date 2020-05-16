namespace Dance_school.ButtonsForms
{
    partial class Lesson
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
            this.TimeLbl = new System.Windows.Forms.Label();
            this.HallLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet10 = new Dance_school.dance_schoolDataSet10();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet11 = new Dance_school.dance_schoolDataSet11();
            this.ExistingLbl = new System.Windows.Forms.Label();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet12 = new Dance_school.dance_schoolDataSet12();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dance_schoolDataSet13 = new Dance_school.dance_schoolDataSet13();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.TimeTbx = new System.Windows.Forms.MaskedTextBox();
            this.DateTbx = new System.Windows.Forms.MaskedTextBox();
            this.scheduleTableAdapter = new Dance_school.dance_schoolDataSet10TableAdapters.ScheduleTableAdapter();
            this.roomTableAdapter = new Dance_school.dance_schoolDataSet11TableAdapters.RoomTableAdapter();
            this.groupTableAdapter = new Dance_school.dance_schoolDataSet12TableAdapters.GroupTableAdapter();
            this.courseTableAdapter = new Dance_school.dance_schoolDataSet13TableAdapters.CourseTableAdapter();
            this.LessonsList = new System.Windows.Forms.ListBox();
            this.RoomList = new System.Windows.Forms.ListBox();
            this.GroupList = new System.Windows.Forms.ListBox();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.LessonsName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseLbl
            // 
            this.CloseLbl.AutoSize = true;
            this.CloseLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.CloseLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseLbl.Location = new System.Drawing.Point(480, 9);
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
            this.CancelBtn.Location = new System.Drawing.Point(379, 433);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 28;
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
            this.OKBtn.Location = new System.Drawing.Point(37, 433);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(103, 33);
            this.OKBtn.TabIndex = 27;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLbl.Location = new System.Drawing.Point(57, 167);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(43, 17);
            this.TimeLbl.TabIndex = 33;
            this.TimeLbl.Text = "Time:";
            // 
            // HallLbl
            // 
            this.HallLbl.AutoSize = true;
            this.HallLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HallLbl.Location = new System.Drawing.Point(57, 218);
            this.HallLbl.Name = "HallLbl";
            this.HallLbl.Size = new System.Drawing.Size(36, 17);
            this.HallLbl.TabIndex = 32;
            this.HallLbl.Text = "Hall:";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateLbl.Location = new System.Drawing.Point(57, 109);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(42, 17);
            this.DateLbl.TabIndex = 31;
            this.DateLbl.Text = "Date:";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.dance_schoolDataSet10;
            // 
            // dance_schoolDataSet10
            // 
            this.dance_schoolDataSet10.DataSetName = "dance_schoolDataSet10";
            this.dance_schoolDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dance_schoolDataSet11;
            // 
            // dance_schoolDataSet11
            // 
            this.dance_schoolDataSet11.DataSetName = "dance_schoolDataSet11";
            this.dance_schoolDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExistingLbl
            // 
            this.ExistingLbl.AutoSize = true;
            this.ExistingLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExistingLbl.Location = new System.Drawing.Point(57, 9);
            this.ExistingLbl.Name = "ExistingLbl";
            this.ExistingLbl.Size = new System.Drawing.Size(60, 17);
            this.ExistingLbl.TabIndex = 36;
            this.ExistingLbl.Text = "Existing:";
            this.ExistingLbl.Visible = false;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.dance_schoolDataSet12;
            // 
            // dance_schoolDataSet12
            // 
            this.dance_schoolDataSet12.DataSetName = "dance_schoolDataSet12";
            this.dance_schoolDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupLbl.Location = new System.Drawing.Point(57, 297);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(52, 17);
            this.GroupLbl.TabIndex = 38;
            this.GroupLbl.Text = "Group:";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dance_schoolDataSet13;
            // 
            // dance_schoolDataSet13
            // 
            this.dance_schoolDataSet13.DataSetName = "dance_schoolDataSet13";
            this.dance_schoolDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CourseLbl.Location = new System.Drawing.Point(57, 368);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(57, 17);
            this.CourseLbl.TabIndex = 40;
            this.CourseLbl.Text = "Course:";
            // 
            // TimeTbx
            // 
            this.TimeTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.TimeTbx.BeepOnError = true;
            this.TimeTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.TimeTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TimeTbx.Location = new System.Drawing.Point(176, 167);
            this.TimeTbx.Mask = "00:00";
            this.TimeTbx.Name = "TimeTbx";
            this.TimeTbx.Size = new System.Drawing.Size(205, 28);
            this.TimeTbx.TabIndex = 42;
            this.TimeTbx.ValidatingType = typeof(System.DateTime);
            // 
            // DateTbx
            // 
            this.DateTbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.DateTbx.BeepOnError = true;
            this.DateTbx.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.DateTbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DateTbx.Location = new System.Drawing.Point(176, 109);
            this.DateTbx.Mask = "00/00/0000";
            this.DateTbx.Name = "DateTbx";
            this.DateTbx.Size = new System.Drawing.Size(205, 28);
            this.DateTbx.TabIndex = 43;
            this.DateTbx.ValidatingType = typeof(System.DateTime);
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // LessonsList
            // 
            this.LessonsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.LessonsList.DataSource = this.scheduleBindingSource;
            this.LessonsList.DisplayMember = "name";
            this.LessonsList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.LessonsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LessonsList.FormattingEnabled = true;
            this.LessonsList.ItemHeight = 20;
            this.LessonsList.Location = new System.Drawing.Point(176, 9);
            this.LessonsList.Name = "LessonsList";
            this.LessonsList.Size = new System.Drawing.Size(205, 24);
            this.LessonsList.TabIndex = 44;
            this.LessonsList.Visible = false;
            // 
            // RoomList
            // 
            this.RoomList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.RoomList.DataSource = this.roomBindingSource;
            this.RoomList.DisplayMember = "name";
            this.RoomList.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.RoomList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.RoomList.FormattingEnabled = true;
            this.RoomList.ItemHeight = 20;
            this.RoomList.Location = new System.Drawing.Point(176, 218);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(205, 24);
            this.RoomList.TabIndex = 45;
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
            this.GroupList.Location = new System.Drawing.Point(176, 297);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(205, 24);
            this.GroupList.TabIndex = 46;
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
            this.CourseList.Location = new System.Drawing.Point(176, 368);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(205, 24);
            this.CourseList.TabIndex = 47;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLb.Location = new System.Drawing.Point(57, 64);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(49, 17);
            this.NameLb.TabIndex = 48;
            this.NameLb.Text = "Name:";
            this.NameLb.Visible = false;
            // 
            // LessonsName
            // 
            this.LessonsName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.LessonsName.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F);
            this.LessonsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.LessonsName.Location = new System.Drawing.Point(176, 64);
            this.LessonsName.Name = "LessonsName";
            this.LessonsName.Size = new System.Drawing.Size(205, 28);
            this.LessonsName.TabIndex = 49;
            this.LessonsName.Visible = false;
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(509, 535);
            this.Controls.Add(this.LessonsName);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.LessonsList);
            this.Controls.Add(this.DateTbx);
            this.Controls.Add(this.TimeTbx);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.ExistingLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.HallLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CloseLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddLesson";
            this.Load += new System.EventHandler(this.Lesson_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lesson_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lesson_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lesson_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dance_schoolDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label HallLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label ExistingLbl;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.MaskedTextBox TimeTbx;
        private System.Windows.Forms.MaskedTextBox DateTbx;
        private dance_schoolDataSet10 dance_schoolDataSet10;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private dance_schoolDataSet10TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private dance_schoolDataSet11 dance_schoolDataSet11;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private dance_schoolDataSet11TableAdapters.RoomTableAdapter roomTableAdapter;
        private dance_schoolDataSet12 dance_schoolDataSet12;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private dance_schoolDataSet12TableAdapters.GroupTableAdapter groupTableAdapter;
        private dance_schoolDataSet13 dance_schoolDataSet13;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private dance_schoolDataSet13TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.ListBox LessonsList;
        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.ListBox GroupList;
        private System.Windows.Forms.ListBox CourseList;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox LessonsName;
    }
}