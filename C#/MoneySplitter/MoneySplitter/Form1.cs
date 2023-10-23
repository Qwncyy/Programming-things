using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneySplitter
{
    public partial class MoneySplitter : Form
    {
        public MoneySplitter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblMoney_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSplitMoney_Click(object sender, EventArgs e)
        {
            float Money;
            int NumPeople;
            float MoneySplit;
            //input money
            Money = float.Parse(txtMoney.Text);

            //input Number of people
            NumPeople = int.Parse(txtNumPppl.Text);

            //Calculate money split
            MoneySplit = Money / NumPeople;

            //output Money split

            txtMoneySplit.Text = MoneySplit.ToString();

        }
    }
}
