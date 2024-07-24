using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek_Sipariş_Örneği
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Adres Ve Telefon Bilgilerinizi Giriniz.");
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Adres Bilgilerinizi Giriniz.");
            }

            else if (textBox1.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası 11 Haneli Olmalıdır.");
            }
            else
            {
                MessageBox.Show("Adres Ve Telefon Bilgileri Kaydedildi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "" && textBox1.Text.Length == 11)
            {
                MessageBox.Show("Sipariş Tamamlandı.");
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girildi");
            }
        }
    }
}
