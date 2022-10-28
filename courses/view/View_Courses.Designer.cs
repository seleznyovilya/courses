namespace courses
{
    partial class View_Courses
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
            this.tvCourses = new System.Windows.Forms.DataGridView();
            this.LBname_of_course = new System.Windows.Forms.TextBox();
            this.tbTypeCourse = new System.Windows.Forms.TextBox();
            this.LBamount_day_of_course = new System.Windows.Forms.TextBox();
            this.lname_of_course = new System.Windows.Forms.Label();
            this.ltype_of_course = new System.Windows.Forms.Label();
            this.lamount_day_of_course = new System.Windows.Forms.Label();
            this.bNew = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.LBcode_of_course = new System.Windows.Forms.TextBox();
            this.lcode_of_course = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tvCourses
            // 
            this.tvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvCourses.Location = new System.Drawing.Point(273, 13);
            this.tvCourses.Name = "tvCourses";
            this.tvCourses.Size = new System.Drawing.Size(663, 332);
            this.tvCourses.TabIndex = 0;
            this.tvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBname_of_course
            // 
            this.LBname_of_course.Location = new System.Drawing.Point(28, 122);
            this.LBname_of_course.Name = "LBname_of_course";
            this.LBname_of_course.Size = new System.Drawing.Size(219, 20);
            this.LBname_of_course.TabIndex = 1;
            // 
            // tbTypeCourse
            // 
            this.tbTypeCourse.Location = new System.Drawing.Point(28, 161);
            this.tbTypeCourse.Name = "tbTypeCourse";
            this.tbTypeCourse.Size = new System.Drawing.Size(219, 20);
            this.tbTypeCourse.TabIndex = 2;
            // 
            // LBamount_day_of_course
            // 
            this.LBamount_day_of_course.Location = new System.Drawing.Point(28, 200);
            this.LBamount_day_of_course.Name = "LBamount_day_of_course";
            this.LBamount_day_of_course.Size = new System.Drawing.Size(219, 20);
            this.LBamount_day_of_course.TabIndex = 3;
            // 
            // lname_of_course
            // 
            this.lname_of_course.AutoSize = true;
            this.lname_of_course.Location = new System.Drawing.Point(28, 106);
            this.lname_of_course.Name = "lname_of_course";
            this.lname_of_course.Size = new System.Drawing.Size(57, 13);
            this.lname_of_course.TabIndex = 4;
            this.lname_of_course.Text = "Название";
            // 
            // ltype_of_course
            // 
            this.ltype_of_course.AutoSize = true;
            this.ltype_of_course.Location = new System.Drawing.Point(25, 145);
            this.ltype_of_course.Name = "ltype_of_course";
            this.ltype_of_course.Size = new System.Drawing.Size(26, 13);
            this.ltype_of_course.TabIndex = 5;
            this.ltype_of_course.Text = "Тип";
            // 
            // lamount_day_of_course
            // 
            this.lamount_day_of_course.AutoSize = true;
            this.lamount_day_of_course.Location = new System.Drawing.Point(28, 184);
            this.lamount_day_of_course.Name = "lamount_day_of_course";
            this.lamount_day_of_course.Size = new System.Drawing.Size(142, 13);
            this.lamount_day_of_course.TabIndex = 6;
            this.lamount_day_of_course.Text = "Количество дней обучения";
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(31, 248);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(219, 23);
            this.bNew.TabIndex = 7;
            this.bNew.Text = "Добавить";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(31, 277);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(219, 23);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(31, 306);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(219, 23);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // LBcode_of_course
            // 
            this.LBcode_of_course.Location = new System.Drawing.Point(28, 83);
            this.LBcode_of_course.Name = "LBcode_of_course";
            this.LBcode_of_course.Size = new System.Drawing.Size(219, 20);
            this.LBcode_of_course.TabIndex = 10;
            // 
            // lcode_of_course
            // 
            this.lcode_of_course.AutoSize = true;
            this.lcode_of_course.Location = new System.Drawing.Point(28, 67);
            this.lcode_of_course.Name = "lcode_of_course";
            this.lcode_of_course.Size = new System.Drawing.Size(58, 13);
            this.lcode_of_course.TabIndex = 11;
            this.lcode_of_course.Text = "Код курса";
            // 
            // View_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 366);
            this.Controls.Add(this.lcode_of_course);
            this.Controls.Add(this.LBcode_of_course);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.lamount_day_of_course);
            this.Controls.Add(this.ltype_of_course);
            this.Controls.Add(this.lname_of_course);
            this.Controls.Add(this.LBamount_day_of_course);
            this.Controls.Add(this.tbTypeCourse);
            this.Controls.Add(this.LBname_of_course);
            this.Controls.Add(this.tvCourses);
            this.Name = "View_Courses";
            this.Text = "Управление курсами Оргранизации";
            this.Load += new System.EventHandler(this.CoursesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tvCourses;
        private System.Windows.Forms.TextBox LBname_of_course;
        private System.Windows.Forms.TextBox tbTypeCourse;
        private System.Windows.Forms.TextBox LBamount_day_of_course;
        private System.Windows.Forms.Label lname_of_course;
        private System.Windows.Forms.Label ltype_of_course;
        private System.Windows.Forms.Label lamount_day_of_course;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox LBcode_of_course;
        private System.Windows.Forms.Label lcode_of_course;
    }
}