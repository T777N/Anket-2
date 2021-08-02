using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _______ListBox________SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdTxb_TextChanged(object sender, EventArgs e)
        {
        }

        private void ElaveEtBtn_Click(object sender, EventArgs e)
        {
            _.Items.Add(AdTxb.Text);
            _.Items.Add(SoyadTxb.Text);
            _.Items.Add(EmailTxb.Text);
            _.Items.Add(TelTxb.Text);
            _.Items.Add(DogumTxb.Text);

        }

        private void DeyisBtn_Click(object sender, EventArgs e)
        {
            _.Items.Clear();
            _.Items.Add(AdTxb.Text);
            _.Items.Add(SoyadTxb.Text);
            _.Items.Add(EmailTxb.Text);
            _.Items.Add(TelTxb.Text);
            _.Items.Add(DogumTxb.Text);

        }
    }
}
