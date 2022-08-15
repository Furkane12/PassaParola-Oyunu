using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        double puan = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki Soru";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                button4.BackColor = Color.Yellow;
            }

            if (soruno==2)
            {
                richTextBox1.Text = "Yeşilliği İle Ünlü Marmara İlimiz?";
                button5.BackColor = Color.Yellow;
            }

            if (soruno==3)
            {
                richTextBox1.Text = "Müslümanların Kutsal Günü?";
                button6.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu İle Ünlü İlimiz?";
                button7.BackColor = Color.Yellow;               
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin Zıt Anlamlısı?";
                button8.BackColor = Color.Yellow;
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali?";
                button9.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button10.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin Kötü Karne Getirince Bakıştığı Nesne?";
                button11.BackColor = Color.Yellow;
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "Gülü İle Ünlü İlimiz?";
                button12.BackColor = Color.Yellow;
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin Diğer İsmi?";
                button13.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri Bir Topluluk?";
                button14.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın Meşhur Meyvesi";
                button15.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                richTextBox1.Text = "Her Yıl Bahar Aylarında Düzenlenen Meşhur Çiçek Festivali?";
                button16.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. Ayı?";
                button17.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli Bİr Müzik Aleti?";
                button18.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                button19.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların Pek Sevmediği Pirinç Havuç Gibi Sebzeler İle Yapılan Yemek?";
                button20.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın Sulatını?";
                button21.BackColor = Color.Yellow;
            }

            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizce de Yılan?";
                button22.BackColor = Color.Yellow;
            }

            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin MegaStarı?";
                button23.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit Kelimesinin Eş Anlamlısı?";
                button24.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı İle Ünlü İlimiz?";
                button1.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek Kelimesinin Eş Anlamlısı?";
                button2.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Ege Bölgesinin En Çok Ağaçı Bulunan Yağı da Yapılan Kahvaltı Besini?";
                button3.BackColor = Color.Yellow;
            }

            if (soruno == 25)
            {
                richTextBox1.Text = "Süperlig`i 1. Olarak bitiren takım ne unvanı kazanır?";
                button26.BackColor = Color.Yellow;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            puan += 4;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();

                        }
                        break;

                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            puan += 4;
                            label2.Text=dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button6.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button7.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button8.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button9.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();

                        }
                        break;

                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button10.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();

                        }
                        break;

                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button11.BackColor = Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
                        break;

                    case 9:
                        if(textBox1.Text=="ısparta") 
                        {
                            button12.BackColor=Color.Green;
                            puan += 4;
                            dogru++;
                            label2.Text = dogru.ToString();
                            label5.Text = puan.ToString();
                        }
                        else {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            puan -= 4;
                            label4.Text = yanlis.ToString();
                            label5.Text = puan.ToString();
                        }
	                   break;

                    case 10:
                       if (textBox1.Text == "içel")
                       {
                           button13.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button13.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 11:
                       if (textBox1.Text == "jandarma")
                       {
                           button14.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button14.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       
                       break;

                    case 12:
                       if (textBox1.Text == "kayısı")
                       {
                           button15.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button15.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 13:
                       if (textBox1.Text == "lale festivali")
                       {
                           button16.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button16.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 14:
                       if (textBox1.Text == "mart")
                       {
                           button17.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button17.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 15:
                       if (textBox1.Text == "ney")
                       {
                           button18.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button18.BackColor=Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 16:
                       if (textBox1.Text == "ozan")
                       {
                           button19.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button19.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 17:
                       if (textBox1.Text == "pırasa")
                       {
                           button20.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button20.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 18:
                       if (textBox1.Text == "ramazan")
                       {
                           button21.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button21.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 19:
                       if (textBox1.Text == "snake")
                       {
                           button22.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button22.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 20:
                       if (textBox1.Text == "tarkan")
                       {
                           button23.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button23.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 21:
                       if (textBox1.Text == "umut")
                       {
                           button24.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button24.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 22:
                       if (textBox1.Text == "van")
                       {
                           button1.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button1.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 23:
                       if (textBox1.Text == "yıldırım")
                       {
                           button2.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button2.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 24:
                       if (textBox1.Text == "zeytin")
                       {
                           button3.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button3.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       break;

                    case 25:
                       if (textBox1.Text == "şampiyon")
                       {
                           button26.BackColor = Color.Green;
                           puan += 4;
                           dogru++;
                           label2.Text = dogru.ToString();
                           label5.Text = puan.ToString();
                       }
                       else
                       {
                           button26.BackColor = Color.Red;
                           yanlis++;
                           puan -= 4;
                           label4.Text = yanlis.ToString();
                           label5.Text = puan.ToString();
                       }
                       MessageBox.Show("Tebrikler, Oyunumuzun Sonuna Geldiniz. Katıldığınız için Teşekkür Ederiz.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       MessageBox.Show("Doğru Sayınız: " + dogru + "\n Yanlış Sayınız: " + yanlis + "\n Puanınız: " + puan);
                       break;
                }
            }
        }

        private void Temizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
