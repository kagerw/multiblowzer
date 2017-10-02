using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtubemultibrouzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            WB1.Navigate(br1url.Text);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bwurl1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Web1.Navigate(new Uri(bwurl1.Text));
            }
            catch
            {

            }
        }

        private void bwurl2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Web2.Navigate(new Uri(bwurl2.Text));
            }
            catch { }


        }
        private void bwurl3_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Web3.Navigate(new Uri(bwurl3.Text));
            }
            catch  { }
        }
    }
}
