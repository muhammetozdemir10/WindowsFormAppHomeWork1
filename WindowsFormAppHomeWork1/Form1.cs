using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAppHomeWork1
{
    public partial class Form1 : Form
    {
        /*
         * (Sayac Programi)
         * 
         * [TASARIM]
         * - Birtane azaltma tusu olacak
         * - Birtane artirma tusu olacak
         * - Birtane Sayaci gosteren yazi alani (Label) olacak
         * 
         * [KOD]
         * Birtane artirma fonksiyonu olusturulacak. Fonksyion adi = IncreaseCounter.
         * Birtane azaltma fonksiyonu olusturulacak. Fonksyion adi = DecreaseCounter.
         * Birtane sayac degiskeni olsuturulacak. Degisken adi = counter.
         * NOT: counter degiskeni class scope'unda tanimlanmalidir!
         * 
         * Eklenen butonlarin tiklama olaylarin olusturulacak. 
         * (Tasarimda buttona cift ciklayarak yababilirsin).
         * 
         * Olusturulan click olay fonksiyonlarin icinde olusturdugun IncreaseCounter ve DecreaseCounter
         * fonksiyonlari uygun butonlarin click olay fonksiyonlarinda cagrilacak.
         * 
         * DecreaseCounter fonksiyonunda counter sifirin altinda gecmeyecek sekilde engellenmelidir.
         */

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void IncreaseCounter()
        {
            counter++;
        }

        void DecreaseCounter()
        {
            if (counter >= 1 )
            {
                counter--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DecreaseCounter();
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncreaseCounter();
            label1.Text = counter.ToString();

        }
    }
}
