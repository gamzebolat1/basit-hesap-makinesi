using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox_ile_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1=Convert.ToInt32(txtsayi1.Text);
            s2=Convert.ToInt32(txtsayi2.Text);
            sonuc = s1 + s2;
            label3.Text = "sonuc= " + sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(txtsayi1.Text);
            s2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = s1 - s2;
            label3.Text = "sonuc= " + sonuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(txtsayi1.Text);
            s2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = s1 * s2;
            label3.Text = "sonuc= " + sonuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(txtsayi1.Text);
            s2 = Convert.ToInt32(txtsayi2.Text);
            sonuc = s1 / s2;
            label3.Text = "sonuc= " + sonuc;
        }
    }
}
