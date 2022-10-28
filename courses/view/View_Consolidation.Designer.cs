namespace courses
{
    partial class View_Consolidation
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
            this.LBteacher = new System.Windows.Forms.ComboBox();
            this.LBname_of_course = new System.Windows.Forms.ComboBox();
            this.dBegin = new System.Windows.Forms.DateTimePicker();
            this.dEnd = new System.Windows.Forms.DateTimePicker();
            this.bAdd = new System.Windows.Forms.Button();
            this.lteacher = new System.Windows.Forms.Label();
            this.lname_of_course = new System.Windows.Forms.Label();
            this.lstart_course = new System.Windows.Forms.Label();
            this.lend_of_course = new System.Windows.Forms.Label();
            this.tvConsolidation = new System.Windows.Forms.DataGridView();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvConsolidation)).BeginInit();
            this.SuspendLayout();
            // 
            // LBteacher
            // 
            this.LBteacher.FormattingEnabled = true;
            this.LBteacher.Location = new System.Drawing.Point(23, 39);
            this.LBteacher.Name = "LBteacher";
            this.LBteacher.Size = new System.Drawing.Size(121, 21);
            this.LBteacher.TabIndex = 0;
            // 
            // LBname_of_course
            // 
            this.LBname_of_course.FormattingEnabled = true;
            this.LBname_of_course.Location = new System.Drawing.Point(23, 79);
            this.LBname_of_course.Name = "LBname_of_course";
            this.LBname_of_course.Size = new System.Drawing.Size(121, 21);
            this.LBname_of_course.TabIndex = 1;
            // 
            // dBegin
            // 
            this.dBegin.CustomFormat = "yyyy-MM-dd";
            this.dBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dBegin.Location = new System.Drawing.Point(23, 119);
            this.dBegin.Name = "dBegin";
            this.dBegin.Size = new System.Drawing.Size(121, 20);
            this.dBegin.TabIndex = 2;
            // 
            // dEnd
            // 
            this.dEnd.CustomFormat = "yyyy-MM-dd";
            this.dEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dEnd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dEnd.Location = new System.Drawing.Point(23, 158);
            this.dEnd.Name = "dEnd";
            this.dEnd.Size = new System.Drawing.Size(121, 20);
            this.dEnd.TabIndex = 3;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(23, 355);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(121, 47);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Подписать документ";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lteacher
            // 
            this.lteacher.AutoSize = true;
            this.lteacher.Location = new System.Drawing.Point(23, 23);
            this.lteacher.Name = "lteacher";
            this.lteacher.Size = new System.Drawing.Size(86, 13);
            this.lteacher.TabIndex = 6;
            this.lteacher.Text = "Преподаватель";
            // 
            // lname_of_course
            // 
            this.lname_of_course.AutoSize = true;
            this.lname_of_course.Location = new System.Drawing.Point(23, 63);
            this.lname_of_course.Name = "lname_of_course";
            this.lname_of_course.Size = new System.Drawing.Size(31, 13);
            this.lname_of_course.TabIndex = 7;
            this.lname_of_course.Text = "Курс";
            // 
            // lstart_course
            // 
            this.lstart_course.AutoSize = true;
            this.lstart_course.Location = new System.Drawing.Point(23, 103);
            this.lstart_course.Name = "lstart_course";
            this.lstart_course.Size = new System.Drawing.Size(120, 13);
            this.lstart_course.TabIndex = 8;
            this.lstart_course.Text = "Дата начала обучения";
            // 
            // lend_of_course
            // 
            this.lend_of_course.AutoSize = true;
            this.lend_of_course.Location = new System.Drawing.Point(23, 142);
            this.lend_of_course.Name = "lend_of_course";
            this.lend_of_course.Size = new System.Drawing.Size(89, 13);
            this.lend_of_course.TabIndex = 9;
            this.lend_of_course.Text = "Дата окончания";
            // 
            // tvConsolidation
            // 
            this.tvConsolidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvConsolidation.Location = new System.Drawing.Point(171, 23);
            this.tvConsolidation.Name = "tvConsolidation";
            this.tvConsolidation.Size = new System.Drawing.Size(640, 379);
            this.tvConsolidation.TabIndex = 10;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(22, 302);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(121, 47);
            this.bDelete.TabIndex = 11;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(23, 249);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(121, 47);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // View_Consolidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 421);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tvConsolidation);
            this.Controls.Add(this.lend_of_course);
            this.Controls.Add(this.lstart_course);
            this.Controls.Add(this.lname_of_course);
            this.Controls.Add(this.lteacher);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dEnd);
            this.Controls.Add(this.dBegin);
            this.Controls.Add(this.LBname_of_course);
            this.Controls.Add(this.LBteacher);
            this.Name = "View_Consolidation";
            this.Text = "Прикрепление преподавателей к Курсам";
            this.Load += new System.EventHandler(this.ConsolidationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvConsolidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LBteacher;
        private System.Windows.Forms.ComboBox LBname_of_course;
        private System.Windows.Forms.DateTimePicker dBegin;
        private System.Windows.Forms.DateTimePicker dEnd;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lteacher;
        private System.Windows.Forms.Label lname_of_course;
        private System.Windows.Forms.Label lstart_course;
        private System.Windows.Forms.Label lend_of_course;
        private System.Windows.Forms.DataGridView tvConsolidation;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
    }
}