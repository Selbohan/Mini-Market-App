using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantin_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int cay, kahve, tost, kraker, cikolata, simit, toplam,su;
            su = Convert.ToInt32(txtsu.Text);
            cay = Convert.ToInt32(txtcay.Text);
            kahve = Convert.ToInt32(txtkahve.Text);
            tost = Convert.ToInt32(txttost.Text);
            kraker = Convert.ToInt32(txtkraker.Text);
            cikolata = Convert.ToInt32(txtcikolata.Text);
            simit = Convert.ToInt32(txtsimit.Text);

            toplam = su * 1 + cay * 2 * kahve * 2 + tost * 4 + kraker * 2 + cikolata * 3 + simit * 2;
            lbtoplam.Text = toplam.ToString()+"TL";

            kasatutar = kasatutar + toplam;
            lbkasa.Text = kasatutar.ToString() + "TL"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsu.Text = "";
            txtcay.Text = "";
            txtkahve.Text = "";
            txttost.Text = "";
            txtkraker.Text = "";
            txtcikolata.Text = "";
            txtsimit.Text = "";
            lbtoplam.Text = "";
            txtsu.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
