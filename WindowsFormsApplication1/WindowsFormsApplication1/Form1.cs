using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[101];
            int sayac = 0;

            Random random = new Random();
            while (sayac < 100)
            {
                int randomSayi = random.Next(0,1000);
                if (sayilar.Contains(randomSayi) == false) {
                    sayilar[sayac] = randomSayi;
                    sayac++;
                }
            }

            int while2 = 0;
            while (while2 <100)
            {
                listBox1.Items.Add(sayilar[while2]);
                while2++;
            }

        }
    }
}
