using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi1 > sayi2)
            {
                MessageBox.Show(" 1.sayı 2.sayıdan büyüktür. ");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar birbirine eşittir.");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.sayı 1.sayıdan büyüktür.");
            }
        }
    }
}
