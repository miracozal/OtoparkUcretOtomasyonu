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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            MessageBox.Show("Araç türünü işaretleyiniz, giriş ve çıkış belirtilen alanlara giriniz. Saniye değerleri yoksayılacaktır.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aracKalmaVakti;
            int dakika, saat;
            dakika = dateTimePicker2.Value.Minute - dateTimePicker1.Value.Minute;
            saat = dateTimePicker2.Value.Hour - dateTimePicker1.Value.Hour;
            aracKalmaVakti = saat * 60 + dakika;
            if (radioButton1.Checked == true)
            {
                if (aracKalmaVakti > 0)
                {
                    if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                    {
                        textBox3.Text = "10.75 ₺";
                    }
                    else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                    {
                        textBox3.Text = "19.50 ₺";
                    }
                    else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                    {
                        textBox3.Text = "23.50 ₺";
                    }
                    else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                    {
                        textBox3.Text = "25.75 ₺";
                    }
                    else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                    {
                        textBox3.Text = "32.50 ₺";
                    }
                }
                else if (aracKalmaVakti < 0)
                {
                    aracKalmaVakti = 1440 + aracKalmaVakti;
                    if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                    {
                        textBox3.Text = "10.75 ₺";
                    }
                    else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                    {
                        textBox3.Text = "19.50 ₺";
                    }
                    else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                    {
                        textBox3.Text = "23.50 ₺";
                    }
                    else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                    {
                        textBox3.Text = "25.75 ₺";
                    }
                    else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                    {
                        textBox3.Text = "32.50 ₺";
                    }
                }
                else if (aracKalmaVakti == 0)
                {
                    MessageBox.Show("Lütfen istenilen değerleri girdiğinizden emin olunuz.");
                }
            }

            if (radioButton2.Checked == true)
            {
                if (aracKalmaVakti > 0)
                {
                    if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                    {
                        textBox3.Text = "19.50 ₺";
                    }
                    else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                    {
                        textBox3.Text = "25.50 ₺";
                    }
                    else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                    {
                        textBox3.Text = "28.00 ₺";
                    }
                    else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                    {
                        textBox3.Text = "34.50 ₺";
                    }
                    else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                    {
                        textBox3.Text = "43.50 ₺";
                    }
                }
                else if (aracKalmaVakti < 0)
                {
                    aracKalmaVakti = 1440 + aracKalmaVakti;
                    if ((0 < aracKalmaVakti) && (aracKalmaVakti <= 60))
                    {
                        textBox3.Text = "19.50 ₺";
                    }
                    else if ((60 < aracKalmaVakti) && (aracKalmaVakti <= 180))
                    {
                        textBox3.Text = "25.50 ₺";
                    }
                    else if ((180 < aracKalmaVakti) && (aracKalmaVakti <= 360))
                    {
                        textBox3.Text = "28.00 ₺";
                    }
                    else if ((360 < aracKalmaVakti) && (aracKalmaVakti <= 720))
                    {
                        textBox3.Text = "34.50 ₺";
                    }
                    else if ((720 < aracKalmaVakti) && (aracKalmaVakti <= 1440))
                    {
                        textBox3.Text = "43.50 ₺";
                    }
                }
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
                "Ücretlendirme detayları;\nOTOMOBİL\n0-1 saat : 10.75₺\n1-3 saat : 19.50₺\n3-6 saat : 23.50₺\n6-12 saat : 25.75₺\n12-24 saat : 32.50₺\nOTOBÜS\n0-1 saat : 19.50₺\n1-3 saat : 25.50₺\n3-6 saat : 28.00₺\n6-12 saat : 34.50₺\n12-24 saat : 43.50₺\n'Hesapla' butonuna tıklamanız durumunda ücret, çıkış ve giriş saatleri arasındaki fark baz alınarak hesaplanacaktır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 yeniForm = new Form1();
            yeniForm.Show();
        }
    }
}
