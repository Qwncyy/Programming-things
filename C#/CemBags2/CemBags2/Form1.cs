using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemBags2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string customerName; //Global variable

        private void btnNameInput_Click(object sender, EventArgs e)
        {
            //variables
            

             customerName = txtNameInput.Text;

        }

        private void txtNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateBagPrice_Click(object sender, EventArgs e)
        {
            //Variables
            double cementBagNumber;
            double cementBagsCost;
            double priceInPounds;
            //input number of cement bags

            cementBagNumber = double.Parse(txtNumBagsInput.Text);

            //calculate price of cement bags in pence
            cementBagsCost = cementBagNumber * 93;

            //calculate price in pounds
            priceInPounds = cementBagsCost/100;


            //output final cost
            txtShowPrice.Text = customerName + " you have bought " + cementBagNumber + " bags of cement costing £" + priceInPounds.ToString();
        }

        private void txtNumBagsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShowPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
