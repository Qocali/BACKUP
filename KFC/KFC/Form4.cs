using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KFC
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asoiuEntities1 db = new asoiuEntities1();
            dataGridView1.DataSource = db.orders.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            asoiuEntities1 db = new asoiuEntities1();
            orders ord = new orders();
            ord.name = textBox4.Text;
            ord.surname = textBox5.Text;
            ord.value = Convert.ToInt32(textBox3.Text);
            db.orders.Add(ord);
            db.SaveChanges();
            MessageBox.Show("doing insert succesfully");
            
        }
    }
}
