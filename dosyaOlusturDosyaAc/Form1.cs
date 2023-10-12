using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace dosyaOlusturDosyaAc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaOlusturma()
        {
            string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaismi = @"\" + dosyaismiTxt.Text + ".txt";
            FileStream fs = File.Create(dosyaYolu + dosyaismi);//
            fs.Close();
            
            ///dosyaya yazma//////////////////////

            TextWriter sw = new StreamWriter(dosyaYolu + dosyaismi);
            sw.WriteLine("Deneme 1");
            sw.WriteLine("Deneme 2");
            sw.WriteLine("Deneme 3");
            sw.WriteLine("Deneme 4");
            sw.WriteLine("Deneme 5");
            sw.Close();
        }
        private void dosyaCalistir()
        {
            string dosyaismi = @"\" + dosyaismiTxt.Text + ".txt";
            string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + dosyaismi;

            if (!File.Exists(dosyaYolu))
            {
                MessageBox.Show("Belirtiğiniz Dosya Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var psi = new ProcessStartInfo();
                psi.FileName = dosyaYolu;
                psi.WorkingDirectory = Path.GetDirectoryName(dosyaYolu);
                Process.Start(psi);
            }



        }
        private void olusturBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dosyaismiTxt.Text))
            {
                MessageBox.Show("Dosya İsmi Belirtiniz.");
                return;
            }
            else
            {
                dosyaOlusturma();
            }
        }

        private void calistirBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dosyaismiTxt.Text))
            {
                MessageBox.Show("Dosya İsmi Belirtiniz.");
                return;
            }
            else
            {
                dosyaCalistir();
            }
        }
    }
}
