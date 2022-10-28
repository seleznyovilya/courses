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
            price.date = LBdate_of_document.Text;
            price.price = Convert.ToInt32(tbPrice.Text);
            price.courseid = Convert.ToInt32(LBcourse.SelectedValue);
            Course course = (Course)LBcourse.SelectedItem;
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
            LBcourse.DataSource = db.GetAllCourse();
            LBcourse.DisplayMember = "name";
            LBcourse.ValueMember = "id";
            tvPrice.DataSource = db.GetAllPrice();
        }
    }
}
