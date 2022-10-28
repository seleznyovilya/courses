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
    public partial class View_Teachers : Form
    {
        Teacher teacher = new Teacher();
        Model db = new Model();
        public View_Teachers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher.fio = LBsurname_name_lastname.Text;
            teacher.bithday = LBdate_of_bithday.Text;
            teacher.category = LBcategory.Text;
            teacher.education = LBeducation.Text;
            teacher.gender = LBnuberphone.Text;

            var success = db.AddTeacher(teacher);
            tvTeachers.DataSource = db.GetAllTeacher();
            if (success)
            {
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void TeachersView_Load(object sender, EventArgs e)
        {
            tvTeachers.DataSource = db.GetAllTeacher();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tvTeachers.CurrentRow.Selected = true;
            LBsurname_name_lastname.Text = tvTeachers.Rows[e.RowIndex].Cells[1].Value.ToString();
            LBdate_of_bithday.Text = tvTeachers.Rows[e.RowIndex].Cells[2].Value.ToString();
            LBcategory.Text = tvTeachers.Rows[e.RowIndex].Cells[5].Value.ToString();
            LBeducation.Text = tvTeachers.Rows[e.RowIndex].Cells[4].Value.ToString();
            LBnuberphone.Text = tvTeachers.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacher.id = Convert.ToInt32(tvTeachers.CurrentRow.Cells[0].Value.ToString());
            var success = db.DeleteTeacher(teacher);
            tvTeachers.DataSource = db.GetAllTeacher();
            if (success)
            {
                MessageBox.Show("Преподаватель удален");
            }
            else
                MessageBox.Show("Ошибка...");
        }
    }
}
