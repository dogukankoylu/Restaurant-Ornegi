using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Yemek_Sipariş_Örneği
{
    public partial class Form2 : Form

    {


        public Form2()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 100;
            }
            if (checkBox2.Checked == true)
            {
                toplam += 120;
            }
            if (checkBox3.Checked == true)
            {
                toplam += 150;

            }
            if (checkBox4.Checked == true)
            {
                toplam += 130;
            }
            if (checkBox5.Checked == true)
            {
                toplam += 90;
            }
            if (checkBox6.Checked == true)
            {
                toplam += 90;
            }
            if (checkBox7.Checked == true)
            {
                toplam += 15;
            }
            if (checkBox8.Checked == true)
            {
                toplam += 20;
            }
            if (checkBox9.Checked == true)
            {
                toplam += 25;
            }
            textBox2.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 sayfa3 = new Form3();
            if(textBox2.Text == "0")
            {
                MessageBox.Show("Lütfen en az 1 ürün seçiniz.");
            }
            else
            {
                MessageBox.Show("Sipariş Oluşturuldu.");
                sayfa3.ShowDialog();
            }

            
        }
    }
}
