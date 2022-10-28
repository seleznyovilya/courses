namespace courses
{
    partial class View_Price
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
            this.LBcourse = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.tvPrice = new System.Windows.Forms.DataGridView();
            this.lcourse = new System.Windows.Forms.Label();
            this.lprice = new System.Windows.Forms.Label();
            this.LBdate_of_document = new System.Windows.Forms.DateTimePicker();
            this.LBnumber_of_document = new System.Windows.Forms.TextBox();
            this.lnumber_of_document = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // LBcourse
            // 
            this.LBcourse.FormattingEnabled = true;
            this.LBcourse.Location = new System.Drawing.Point(12, 85);
            this.LBcourse.Name = "LBcourse";
            this.LBcourse.Size = new System.Drawing.Size(164, 21);
            this.LBcourse.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 151);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(164, 20);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(12, 384);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(164, 32);
            this.bNew.TabIndex = 3;
            this.bNew.Text = "Подписать документ";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tvPrice
            // 
            this.tvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvPrice.Location = new System.Drawing.Point(188, 30);
            this.tvPrice.Name = "tvPrice";
            this.tvPrice.Size = new System.Drawing.Size(566, 386);
            this.tvPrice.TabIndex = 4;
            this.tvPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lcourse
            // 
            this.lcourse.AutoSize = true;
            this.lcourse.Location = new System.Drawing.Point(9, 69);
            this.lcourse.Name = "lcourse";
            this.lcourse.Size = new System.Drawing.Size(83, 13);
            this.lcourse.TabIndex = 5;
            this.lcourse.Text = "Выберите курс";
            // 
            // lprice
            // 
            this.lprice.AutoSize = true;
            this.lprice.Location = new System.Drawing.Point(11, 135);
            this.lprice.Name = "lprice";
            this.lprice.Size = new System.Drawing.Size(81, 13);
            this.lprice.TabIndex = 6;
            this.lprice.Text = "Цена без НДС";
            // 
            // LBdate_of_document
            // 
            this.LBdate_of_document.CustomFormat = "yyyy-MM-dd";
            this.LBdate_of_document.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LBdate_of_document.Location = new System.Drawing.Point(12, 112);
            this.LBdate_of_document.Name = "LBdate_of_document";
            this.LBdate_of_document.Size = new System.Drawing.Size(164, 20);
            this.LBdate_of_document.TabIndex = 7;
            // 
            // LBnumber_of_document
            // 
            this.LBnumber_of_document.Location = new System.Drawing.Point(12, 46);
            this.LBnumber_of_document.Name = "LBnumber_of_document";
            this.LBnumber_of_document.Size = new System.Drawing.Size(164, 20);
            this.LBnumber_of_document.TabIndex = 8;
            // 
            // lnumber_of_document
            // 
            this.lnumber_of_document.AutoSize = true;
            this.lnumber_of_document.Location = new System.Drawing.Point(9, 30);
            this.lnumber_of_document.Name = "lnumber_of_document";
            this.lnumber_of_document.Size = new System.Drawing.Size(98, 13);
            this.lnumber_of_document.TabIndex = 9;
            this.lnumber_of_document.Text = "Номер документа";
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 346);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(164, 32);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(12, 308);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(164, 32);
            this.bDelete.TabIndex = 11;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // View_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 430);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.lnumber_of_document);
            this.Controls.Add(this.LBnumber_of_document);
            this.Controls.Add(this.LBdate_of_document);
            this.Controls.Add(this.lprice);
            this.Controls.Add(this.lcourse);
            this.Controls.Add(this.tvPrice);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.LBcourse);
            this.Name = "View_Price";
            this.Text = "Управление ценами на Курсы";
            this.Load += new System.EventHandler(this.PriceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LBcourse;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.DataGridView tvPrice;
        private System.Windows.Forms.Label lcourse;
        private System.Windows.Forms.Label lprice;
        private System.Windows.Forms.DateTimePicker LBdate_of_document;
        private System.Windows.Forms.TextBox LBnumber_of_document;
        private System.Windows.Forms.Label lnumber_of_document;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
    }
}