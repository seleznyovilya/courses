namespace courses
{
    partial class View_Users
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
            this.tvUsers = new System.Windows.Forms.DataGridView();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tvUsers
            // 
            this.tvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvUsers.Location = new System.Drawing.Point(139, 43);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(488, 402);
            this.tvUsers.TabIndex = 0;
            this.tvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(15, 59);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(117, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(15, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(117, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(12, 43);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(61, 13);
            this.lLogin.TabIndex = 4;
            this.lLogin.Text = "Имя входа";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 82);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Пароль";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(16, 189);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(116, 23);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Создать";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // bEdit
            // 
            this.bEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.bEdit.Location = new System.Drawing.Point(15, 218);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(116, 23);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDel
            // 
            this.bDel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bDel.Location = new System.Drawing.Point(12, 247);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(116, 23);
            this.bDel.TabIndex = 10;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // View_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 457);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tvUsers);
            this.Name = "View_Users";
            this.Text = "Рабочее место администратора системы";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tvUsers;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDel;
    }
}