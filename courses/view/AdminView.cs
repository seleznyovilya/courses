using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courses
{
    public partial class AdminView : Form
    {
        Users user = new Users();
        Database db = new Database();
        public AdminView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = db.GetAllUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.login=tbLogin.Text;
            user.password = tbPassword.Text;

            var success = db.AddUser(user);
            dgvUsers.DataSource = db.GetAllUsers();
            if (success)
            {
                MessageBox.Show("Пользователь добавлен");
            }
            else
                MessageBox.Show("Ошибка");
        }



        private void bEdit_Click(object sender, EventArgs e)
        {
            user.id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            user.login = tbLogin.Text;
            user.password = tbPassword.Text;
            db.UpdateUser(user);
            dgvUsers.DataSource = db.GetAllUsers();

        }

        private void bDel_Click(object sender, EventArgs e)
        {
            user.id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            var success = db.DeleteUser(user);
            dgvUsers.DataSource = db.GetAllUsers();
            if (success)
            {
                MessageBox.Show("Пользователь удален");
            }
            else
                MessageBox.Show("Ошибка...");
        }
    }
}
