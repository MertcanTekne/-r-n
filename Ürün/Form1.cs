using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int urun_f = Convert.ToInt32(textBox1.Text);
            int adet = Convert.ToInt32(textBox2.Text);
            urun_f = urun_f * adet;
            double kdv_t = 0.0;
            if (radioButton1.Checked)
            {
                kdv_t = urun_f * 1 / 100;

            }
            else if (radioButton2.Checked)
            {
                kdv_t = urun_f * 18 / 100;
            }
            else if(radioButton3.Checked)
            {
                kdv_t = urun_f * 8 / 100;
            }
            else
            {
                MessageBox.Show("hata");
            }
            MessageBox.Show(kdv_t.ToString());
        }
    }
}
