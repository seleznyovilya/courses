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
    public partial class TeachersView : Form
    {
        Teacher teacher = new Teacher();
        Database db = new Database();
        public TeachersView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher.fio = tbFIO.Text;
            teacher.bithday = dtpBithday.Text;
            teacher.category = tbCategory.Text;
            teacher.education = tbEducation.Text;
            teacher.gender = cbGender.Text;

            var success = db.AddTeacher(teacher);
            dataGridView1.DataSource = db.GetAllTeacher();
            if (success)
            {
                MessageBox.Show("Success");
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void TeachersView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAllTeacher();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            tbFIO.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpBithday.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbEducation.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacher.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var success = db.DeleteTeacher(teacher);
            dataGridView1.DataSource = db.GetAllTeacher();
            if (success)
            {
                MessageBox.Show("Преподаватель удален");
            }
            else
                MessageBox.Show("Ошибка...");
        }
    }
}
