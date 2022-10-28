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
    public partial class View_Application : Form
    {
        Applications applications = new Applications();
        Model db = new Model();
        string stuff_fio;
        string stuff_dolzh;
        public View_Application()
        {
            InitializeComponent();
        }

        private void SendApplicationView_Load(object sender, EventArgs e)
        {
            tvApplication.DataSource = db.GetAllApplication();
            cbCourse.DataSource = db.GetAllCourse();
            cbCourse.DisplayMember = "name";
            cbCourse.ValueMember = "id";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dolzh = LBstuff_pozition.Text;
            string fop = tbFIO.Text;
            stuff_fio = stuff_fio + ","+fop;
            stuff_dolzh = stuff_dolzh + "," + dolzh;
            lvStuff.Items.Add(fop+"-"+dolzh);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            applications.name_of_organization = LBname_of_organization.Text;
            applications.address_of_organization = tbAddressOrg.Text;
            applications.numberphone_organization = tbNumbPhoneOrg.Text;
            applications.email = tbEmail.Text;
            applications.amount_stuff=cbCourse.Items.Count;
            applications.name_surname_lastname_stuff = stuff_fio;
            applications.stuff_position = stuff_dolzh;
            applications.term_of_course = dateTimePicker1.Text;
            applications.idcourse = Convert.ToInt32(cbCourse.SelectedValue);
            var success = db.AddApplication(applications);

            tvApplication.DataSource = db.GetAllApplication();

            if (success)
            {
                MessageBox.Show("Course has been added successfully");
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
