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

namespace Bank
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }
        //Account object

        Account account1;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create account

            account1 = new Account();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Make deposit

            //input the deposit amount
            decimal depositAmount = decimal.Parse(txtAmount.Text);

            account1.make_deposit(depositAmount);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Display the balance
            decimal myBalance = account1.getBalance();

           
                MessageBox.Show("Your balance is £" + myBalance);
     

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal myBalance = account1.getBalance();
            decimal withdrawAmount = decimal.Parse(txtAmount.Text);

            account1.make_withdraw(withdrawAmount);
            if (myBalance < 0)
                MessageBox.Show("Insufficient funds to withdraw");
            return;

        }
    }
}
