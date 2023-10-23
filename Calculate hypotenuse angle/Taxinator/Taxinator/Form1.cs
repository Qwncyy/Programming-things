using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxinator
{//Constant of 4 pounds as that is base fair
    public partial class Form1 : Form
    {
        const float baseFair = 4; 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDistanceCost_Click(object sender, EventArgs e)
        {
            //Variables

            double distance, price, divDist;
            string priceOut
            //recieving the distance
            distance = double.Parse(txtDistanceInput.Text);

            //dividing the distance for price mltiplication

            divDist = distance / 140;

                //obtain the price

            price = divDist * 25;

            priceOut = Math.Truncate(price);

            txtPriceOutput.Text = 


        }

        private void txtDistanceInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
