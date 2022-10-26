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
    public partial class View_Price : Form
    {
        Model db = new Model();
        Price price = new Price();
        
        
        public View_Price()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            price.date = dateTimePicker1.Text;
            price.price = Convert.ToInt32(tbPrice.Text);
            price.courseid = Convert.ToInt32(cbCourse.SelectedValue);
            Course course = (Course)cbCourse.SelectedItem;
            course.price = price.price;
            course.price_VAT=course.price+((course.price/100)*20);
            db.UpdateCourse(course);
            
            db.AddPrice(price);

            tvPrice.DataSource = db.GetAllPrice();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PriceView_Load(object sender, EventArgs e)
        {
            cbCourse.DataSource = db.GetAllCourse();
            cbCourse.DisplayMember = "name";
            cbCourse.ValueMember = "id";
            tvPrice.DataSource = db.GetAllPrice();
        }
    }
}
