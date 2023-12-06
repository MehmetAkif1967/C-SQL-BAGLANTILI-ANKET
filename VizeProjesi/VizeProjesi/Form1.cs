using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeProjesi
{
    public partial class Form1 : Form
    {
        private Control[] originalControls;
        private int clickCount = 0;
        private DataGridView datagrid;
        private TextBox textBoxSoru;
        private Button btncevap1;
        private Button btncevap2;
        private Button btncevap3;
        private Button btncevap4;
        private int toplam = 0;        
        public Form1()
        {
            InitializeComponent();
            originalControls = Controls.Cast<Control>().ToArray();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = MehmetAkifPC\\SQLEXPRESS; Initial Catalog=anketsqlserverDB; Integrated Security = true");
        private void button1_Click_1(object sender, EventArgs e)
        {
            Controls.Clear();

            textBoxSoru = new TextBox();
            textBoxSoru.Location = new Point(111, 36);
            textBoxSoru.Size = new Size(568, 27);
            textBoxSoru.Text = "Ne Amaçla Yazılım Öğrenmek İstiyorsunuz?";
            Controls.Add(textBoxSoru);

            btncevap1 = new Button();
            btncevap1.Location = new Point(82, 110);
            btncevap1.Size = new Size(461, 31);
            btncevap1.Text = "Para Kazanmak İçin";
            btncevap1.Click += btncevap1_Click;
            Controls.Add(btncevap1);

            btncevap2 = new Button();
            btncevap2.Location = new Point(82, 189);
            btncevap2.Size = new Size(461, 31);
            btncevap2.Text = "Web Tasarım İçin";
            btncevap2.Click += btncevap2_Click;
            Controls.Add(btncevap2);

            btncevap3 = new Button();
            btncevap3.Location = new Point(82, 259);
            btncevap3.Size = new Size(461, 31);
            btncevap3.Text = "Mobil App Tasarlamak İçin";
            btncevap3.Click += btncevap3_Click;
            Controls.Add(btncevap3);

            btncevap4 = new Button();
            btncevap4.Location = new Point(82, 341);
            btncevap4.Size = new Size(461, 31);
            btncevap4.Text = "Oyun Yapmak İçin";
            btncevap4.Click += btncevap4_Click;
            Controls.Add(btncevap4);

        }
        private void btncevap1_Click(object sender, EventArgs e)
        {
            clickCount++;
            toplam = toplam + 20;
            if (clickCount <= 7)
            {


                if (clickCount == 1)
                {
                    toplam = toplam + 10;
                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayırıyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {
                    toplam = toplam + 40;
                    string new1TextBoxText = "İlerde Ne İş Yapmak İstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarım";
                    string new1BtnCevap3Text = "Tıpta Uygulama Geliştirme";
                    string new1BtnCevap4Text = "Oyun Geliştirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {
                    toplam = toplam + 30;
                    string new2TextBoxText = "İşini Nasıl Yapmak İstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlı çalışmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalışmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapıyorum";
                    string new2BtnCevap4Text = "Yarı zamanlı ekstra para kazanmak için yapıyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;


                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {
                    toplam = toplam + 10;
                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve İçmek";
                    string new3BtnCevap3Text = "Kısa aralıklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi İzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {
                    toplam += 20;
                    string new4TextBoxText = "Hangi Platforma Uygulama Geliştirmek İstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/İOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {
                    toplam += 40;
                    string new5TextBoxText = "Son Soru: Neden Yazılım?";
                    string new5BtnCevap1Text = "Hızlılık yaratması";
                    string new5BtnCevap2Text = "Yaratıcı olunabilmesi";
                    string new5BtnCevap3Text = "İş imkanı fazla";
                    string new5BtnCevap4Text = "Küçüklüğümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
                if (clickCount == 7)
                {
                    Controls.Clear();
                    datagrid = new DataGridView();
                    datagrid.Location = new Point(116, 49);
                    datagrid.Size = new Size(710, 363);
                    Controls.Add(datagrid);
                    TabloBaglanti();
                    string resultMessage = $"Sonuçlar:\n" +
                                        $"Toplam puanınız: {toplam}\n" +
                                        $"70-130 puan arası: Java dili ve temel web teknolojileri öğrenmelisin \n" +
                                        $"130-180 puan arası: HTML,CSS ve JS gibi dilleri öğrenmelisin\n" +
                                        $"180-220 puan arası: Python dili ve SQL sorgulama dili öğrenmelisin\n" +
                                        $"220-280 puan arası: C,C++ ve C# öğrenmelisin";

                    MessageBox.Show(resultMessage, "Anket Sonuçları");
                    AnketiSifirla();
                }
            }
           
        }
        private void btncevap2_Click(object sender, EventArgs e)
        {
            clickCount++;
            toplam = toplam + 10;
            if (clickCount <= 7)
            {


                if (clickCount == 1)
                {
                    toplam += 20;
                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayırıyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {
                    toplam += 20;
                    string new1TextBoxText = "İlerde Ne İş Yapmak İstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarım";
                    string new1BtnCevap3Text = "Tıpta Uygulama Geliştirme";
                    string new1BtnCevap4Text = "Oyun Geliştirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {
                    toplam += 10;
                    string new2TextBoxText = "İşini Nasıl Yapmak İstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlı çalışmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalışmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapıyorum";
                    string new2BtnCevap4Text = "Yarı zamanlı ekstra para kazanmak için yapıyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {
                    toplam += 40;
                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve İçmek";
                    string new3BtnCevap3Text = "Kısa aralıklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi İzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {
                    toplam += 40;
                    string new4TextBoxText = "Hangi Platforma Uygulama Geliştirmek İstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/İOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {
                    toplam += 30;
                    string new5TextBoxText = "Son Soru: Neden Yazılım?";
                    string new5BtnCevap1Text = "Hızlılık yaratması";
                    string new5BtnCevap2Text = "Yaratıcı olunabilmesi";
                    string new5BtnCevap3Text = "İş imkanı fazla";
                    string new5BtnCevap4Text = "Küçüklüğümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
                if (clickCount == 7)
                {
                    Controls.Clear();
                    datagrid = new DataGridView();
                    datagrid.Location = new Point(116, 49);
                    datagrid.Size = new Size(710, 363);
                    Controls.Add(datagrid);
                    TabloBaglanti();
                    string resultMessage = $"Sonuçlar:\n" +
                                        $"Toplam puanınız: {toplam}\n" +
                                        $"70-130 puan arası: Java dili ve temel web teknolojileri öğrenmelisin \n" +
                                        $"130-180 puan arası: HTML,CSS ve JS gibi dilleri öğrenmelisin\n" +
                                        $"180-220 puan arası: Python dili ve SQL sorgulama dili öğrenmelisin\n" +
                                        $"220-280 puan arası: C,C++ ve C# öğrenmelisin";

                    MessageBox.Show(resultMessage, "Anket Sonuçları");
                    AnketiSifirla();
                }
            }
            
        }
        private void btncevap3_Click(object sender, EventArgs e)
        {
            clickCount++;
            toplam += 30;
            if (clickCount <= 7)
            {


                if (clickCount == 1)
                {
                    toplam += 30;
                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayırıyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {
                    toplam += 10;
                    string new1TextBoxText = "İlerde Ne İş Yapmak İstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarım";
                    string new1BtnCevap3Text = "Tıpta Uygulama Geliştirme";
                    string new1BtnCevap4Text = "Oyun Geliştirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {
                    toplam += 20;
                    string new2TextBoxText = "İşini Nasıl Yapmak İstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlı çalışmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalışmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapıyorum";
                    string new2BtnCevap4Text = "Yarı zamanlı ekstra para kazanmak için yapıyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {
                    toplam += 20;
                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve İçmek";
                    string new3BtnCevap3Text = "Kısa aralıklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi İzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {
                    toplam += 30;
                    string new4TextBoxText = "Hangi Platforma Uygulama Geliştirmek İstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/İOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {
                    toplam += 20;
                    string new5TextBoxText = "Son Soru: Neden Yazılım?";
                    string new5BtnCevap1Text = "Hızlılık yaratması";
                    string new5BtnCevap2Text = "Yaratıcı olunabilmesi";
                    string new5BtnCevap3Text = "İş imkanı fazla";
                    string new5BtnCevap4Text = "Küçüklüğümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
                if (clickCount == 7)
                {
                    Controls.Clear();
                    datagrid = new DataGridView();
                    datagrid.Location = new Point(116, 49);
                    datagrid.Size = new Size(710, 363);
                    Controls.Add(datagrid);
                    TabloBaglanti();
                    string resultMessage = $"Sonuçlar:\n" +
                                        $"Toplam puanınız: {toplam}\n" +
                                        $"70-130 puan arası: Java dili ve temel web teknolojileri öğrenmelisin \n" +
                                        $"130-180 puan arası: HTML,CSS ve JS gibi dilleri öğrenmelisin\n" +
                                        $"180-220 puan arası: Python dili ve SQL sorgulama dili öğrenmelisin\n" +
                                        $"220-280 puan arası: C,C++ ve C# öğrenmelisin";

                    MessageBox.Show(resultMessage, "Anket Sonuçları");
                    AnketiSifirla();
                }
            }           
        }
        private void btncevap4_Click(object sender, EventArgs e)
        {
            clickCount++;
            toplam += 40;
            if (clickCount <= 7)
            {


                if (clickCount == 1)
                {
                    toplam += 40;
                    string newTextBoxText = "Programlamaya Günde Ne kadar Vakit Ayırıyorsun?";
                    string newBtnCevap1Text = "5 saat";
                    string newBtnCevap2Text = "3 - 4 saat";
                    string newBtnCevap3Text = "2 saat";
                    string newBtnCevap4Text = "1 saat";


                    textBoxSoru.Text = newTextBoxText;


                    btncevap1.Text = newBtnCevap1Text;
                    btncevap2.Text = newBtnCevap2Text;
                    btncevap3.Text = newBtnCevap3Text;
                    btncevap4.Text = newBtnCevap4Text;

                }
                if (clickCount == 2)
                {
                    toplam += 30;
                    string new1TextBoxText = "İlerde Ne İş Yapmak İstiyorsunuz?";
                    string new1BtnCevap1Text = "Savunma Sanayi";
                    string new1BtnCevap2Text = "Back-end veya Front-end Web Tasarım";
                    string new1BtnCevap3Text = "Tıpta Uygulama Geliştirme";
                    string new1BtnCevap4Text = "Oyun Geliştirme";


                    textBoxSoru.Text = new1TextBoxText;


                    btncevap1.Text = new1BtnCevap1Text;
                    btncevap2.Text = new1BtnCevap2Text;
                    btncevap3.Text = new1BtnCevap3Text;
                    btncevap4.Text = new1BtnCevap4Text;

                }
                if (clickCount == 3)
                {
                    toplam += 40;
                    string new2TextBoxText = "İşini Nasıl Yapmak İstiyorsun?";
                    string new2BtnCevap1Text = "Tam zamanlı çalışmak istiyorum";
                    string new2BtnCevap2Text = "Freelance çalışmak istiyorum";
                    string new2BtnCevap3Text = "Hobi olarak yapıyorum";
                    string new2BtnCevap4Text = "Yarı zamanlı ekstra para kazanmak için yapıyorum ";


                    textBoxSoru.Text = new2TextBoxText;


                    btncevap1.Text = new2BtnCevap1Text;
                    btncevap2.Text = new2BtnCevap2Text;
                    btncevap3.Text = new2BtnCevap3Text;
                    btncevap4.Text = new2BtnCevap4Text;

                }
                if (clickCount == 4)
                {
                    toplam += 30;
                    string new3TextBoxText = "Programlama Yaparken En Büyük Rutinin Nedir?";
                    string new3BtnCevap1Text = "Müzik Dinlemek";
                    string new3BtnCevap2Text = "Kahve İçmek";
                    string new3BtnCevap3Text = "Kısa aralıklarla esneme hareketleri yapmak";
                    string new3BtnCevap4Text = "Dizi İzlemek";


                    textBoxSoru.Text = new3TextBoxText;


                    btncevap1.Text = new3BtnCevap1Text;
                    btncevap2.Text = new3BtnCevap2Text;
                    btncevap3.Text = new3BtnCevap3Text;
                    btncevap4.Text = new3BtnCevap4Text;

                }
                if (clickCount == 5)
                {
                    toplam += 10;  
                    string new4TextBoxText = "Hangi Platforma Uygulama Geliştirmek İstersiniz?";
                    string new4BtnCevap1Text = "Android";
                    string new4BtnCevap2Text = "Cross-Platform(Çoklu Platform)";
                    string new4BtnCevap3Text = "Windows";
                    string new4BtnCevap4Text = "macOS/İOS";


                    textBoxSoru.Text = new4TextBoxText;


                    btncevap1.Text = new4BtnCevap1Text;
                    btncevap2.Text = new4BtnCevap2Text;
                    btncevap3.Text = new4BtnCevap3Text;
                    btncevap4.Text = new4BtnCevap4Text;

                }
                if (clickCount == 6)
                {
                    toplam += 10;
                    string new5TextBoxText = "Son Soru: Neden Yazılım?";
                    string new5BtnCevap1Text = "Hızlılık yaratması";
                    string new5BtnCevap2Text = "Yaratıcı olunabilmesi";
                    string new5BtnCevap3Text = "İş imkanı fazla";
                    string new5BtnCevap4Text = "Küçüklüğümden beri bilgisayara ilgim var";


                    textBoxSoru.Text = new5TextBoxText;


                    btncevap1.Text = new5BtnCevap1Text;
                    btncevap2.Text = new5BtnCevap2Text;
                    btncevap3.Text = new5BtnCevap3Text;
                    btncevap4.Text = new5BtnCevap4Text;

                }
                if (clickCount == 7)
                {
                    Controls.Clear();
                    datagrid = new DataGridView();
                    datagrid.Location = new Point(116, 49);
                    datagrid.Size = new Size(710, 363);
                    Controls.Add(datagrid);
                    TabloBaglanti();
                    string resultMessage = $"Sonuçlar:\n" +
                                        $"Toplam puanınız: {toplam}\n" +
                                        $"70-130 puan arası: Java dili ve temel web teknolojileri öğrenmelisin \n" +
                                        $"130-180 puan arası: HTML,CSS ve JS gibi dilleri öğrenmelisin\n" +
                                        $"180-220 puan arası: Python dili ve SQL sorgulama dili öğrenmelisin\n" +
                                        $"220-280 puan arası: C,C++ ve C# öğrenmelisin";

                    MessageBox.Show(resultMessage, "Anket Sonuçları");
                    AnketiSifirla();
                }
            }            
        }

        private void AnketiSifirla()
        {
            clickCount = 0;


            Controls.Clear();
            Controls.AddRange(originalControls);


            btncevap1.Click += btncevap1_Click;
            btncevap2.Click += btncevap2_Click;
            btncevap3.Click += btncevap3_Click;
            btncevap4.Click += btncevap4_Click;


        }
        void TabloBaglanti()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from SoruPuan",baglanti);
            DataTable dataTable = new DataTable();
            sda .Fill(dataTable);
            datagrid.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
