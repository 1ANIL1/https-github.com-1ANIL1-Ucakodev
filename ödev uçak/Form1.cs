using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_uçak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "Müdür Ve Üst Yöneticiler") && (textBox1.Text == "9BB47F256561d")) 
            {
                Form2 myform = new Form2();
                myform.Show();
            }

           else if ((comboBox1.Text == "Çalışan") && (textBox1.Text == "35710bizimtakımşampiyon"))

            {
                Form2 myform = new Form2();

                myform.Show();

            }

            else

            {

             MessageBox.Show("yanlış şifre");
            }
        }
    }
}
