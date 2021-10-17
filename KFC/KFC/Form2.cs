using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace KFC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            asoiuEntities1 db = new asoiuEntities1();
            orders ord = new orders();
            ord.name = Form1.ad;
            ord.surname = Form1.soyad;
            ord.value = Convert.ToInt32(label3.Text);
            db.orders.Add(ord);
            db.SaveChanges();
            MessageBox.Show("doing insert succesfully");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            asoiuEntities1 db = new asoiuEntities1();
            orders ord = new orders();
            ord.name = Form1.ad;
            ord.surname = Form1.soyad;
            ord.value = Convert.ToInt32(label4.Text);
            db.orders.Add(ord);
            db.SaveChanges();
            MessageBox.Show("doing insert succesfully");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            asoiuEntities1 db = new asoiuEntities1();
            orders ord = new orders();
            ord.name = Form1.ad;
            ord.surname = Form1.soyad;
            ord.value = Convert.ToInt32(label7.Text);
            db.orders.Add(ord);
            db.SaveChanges();
            MessageBox.Show("doing insert succesfully");
            MessageBox.Show("doing insert succesfully");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
                

        }
    }
}
