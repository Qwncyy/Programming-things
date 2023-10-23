using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendinator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //account object
        VendingMachine machine = new VendingMachine();

        //add chocolate stock
        private void btnStockChocolate_Click(object sender, EventArgs e)
        {
            int addChocolateStock = int.Parse(txtAmount.Text);

            //send the amount entered to chocolate stock in the class
            machine.get_chocolateStock(addChocolateStock);
        }
       

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
        //add crisp stock
        private void btnStockCrisps_Click(object sender, EventArgs e)
        {
            int addCrispStock = int.Parse(txtAmount.Text);
            
            machine.get_crispsStock(addCrispStock);
        }

        private void btnStockWater_Click(object sender, EventArgs e)
        {
            int addWaterStock = int.Parse(txtAmount.Text);

            machine.get_waterStock(addWaterStock);
        }

        private void btnBuyChocolate_Click(object sender, EventArgs e)
        {
            machine.buy_chocolate();
        }

        private void btnBuyCrisps_Click(object sender, EventArgs e)
        {
            machine.buy_crisps();
        }

        private void btnBuyWater_Click(object sender, EventArgs e)
        {
            machine.buy_water();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            //display stock
            int myChocoStocko = machine.checkStockOfChocolate();
            int myCrispStock = machine.checkStockOfCrisps();
            int myWaterStock = machine.checkStockOfWater();
            
            MessageBox.Show("There are "+ myChocoStocko + " pieces of chocolate left "+ "\nThere are " + myCrispStock + " bags of crisps left " + "\nThere are "+myWaterStock+" bottles of water left" );
            

        }
    }
}
