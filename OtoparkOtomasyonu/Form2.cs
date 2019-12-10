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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("Giriş ve çıkış belirtilen alanlara giriniz. Saniye değerleri yoksayılacaktır.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aracKalmaVakti;
            int dakika, saat;
            dakika = dateTimePicker2.Value.Minute - dateTimePicker1.Value.Minute;
            saat = dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour;
            aracKalmaVakti = saat * 60 + dakika;
            if (aracKalmaVakti > 0)
            {
                if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                {
                    textBox3.Text = "5.00 €";
                }
                else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                {
                    textBox3.Text = "7.00 €";
                }
                else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                {
                    textBox3.Text = "10.00 €";
                }
                else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                {
                    textBox3.Text = "12.00 €";
                }
                else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                {
                    textBox3.Text = "15.50 €";
                }
            }
            else if (aracKalmaVakti < 0)
            {
                aracKalmaVakti = 1440 + aracKalmaVakti;
                if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                {
                    textBox3.Text = "5.00 €";
                }
                else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                {
                    textBox3.Text = "7.00 €";
                }
                else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                {
                    textBox3.Text = "10.00 €";
                }
                else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                {
                    textBox3.Text = "12.00 €";
                }
                else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                {
                    textBox3.Text = "15.50 €";
                }
            }
            else if(aracKalmaVakti == 0)
            {
                MessageBox.Show("Lütfen istenilen değerleri girdiğinizden emin olunuz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programımızı kullandığınız için teşekkürler !");
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ücretlendirme detayları;\n0-1 saat : 5.00€\n1-3 saat : 7.00€\n3-6 saat : 10.00€\n6-12 saat : 12.00€\n12-24 saat : 15.50€\n'Hesapla' butonuna tıklamanız durumunda ücret, çıkış ve giriş saatleri arasındaki fark baz alınarak hesaplanacaktır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1();
            yeniForm.Show();
        }
    }
}
