namespace Yemek_Sipariş_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 sayfa2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            sayfa2.ShowDialog();
        }

        Form3 sayfa3 = new Form3();
        private void button3_Click(object sender, EventArgs e)
        {
            sayfa3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
