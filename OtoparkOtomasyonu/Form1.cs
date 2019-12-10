using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBSOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Lütfen otopark türünü seçiniz.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2();
            yeniForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeniForm = new Form3();
            yeniForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programımızı kullandığınız için teşekkürler !");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Seçtiğiniz otopark türüne göre ücretlendirme yapılacaktır.\nÜcretlendirme açık otoparkta 'TL' cinsinden, kapalı otoparkta 'Euro' cinsinden hesaplanacaktır.");
        }
    }
}
