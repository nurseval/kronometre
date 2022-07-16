using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        int saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label5.Text);
            salise++;
            label5.Text = salise.ToString();
            timer1.Interval = 100;
            if(salise == 10)
            {
                salise = 0;
                label5.Text = salise.ToString();
                saniye++;
                label1.Text = saniye.ToString();
                timer1.Interval = 1000;

            }
            if(saniye == 60)
            {
                saniye = 0;
                label1.Text = saniye.ToString();
                saniye++;
                label2.Text= dakika.ToString();
                timer1.Interval = 10000;
            }
        
           

        }
    }
}
