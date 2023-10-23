using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendinator
{
    internal class VendingMachine
    {
        //Attributes

        int chocolateStock;
        int crispStock;
        int waterStock;
       
        public void buy_chocolate()
        {
            chocolateStock = chocolateStock - 1;

        }
        public void get_chocolateStock(int amount)
        {
            chocolateStock = chocolateStock + amount;

        }
        public void buy_crisps()
        {
            crispStock = crispStock - 1;
        }
        public void get_crispsStock(int amount)
        {
            crispStock = crispStock + amount;
        }
        public void buy_water()
        { 
            waterStock = waterStock - 1;
        
        }
        public void get_waterStock(int amount)
        {
            waterStock = waterStock + amount;
        }

        public int checkStockOfChocolate()
        {
            return chocolateStock;
            
        }
        public int checkStockOfCrisps()
        {
            return crispStock;


        }
        public int checkStockOfWater()
        {
            return waterStock;


        }


    }
}
