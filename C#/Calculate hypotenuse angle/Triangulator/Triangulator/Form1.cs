using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateHypotenuse_Click(object sender, EventArgs e)
        {//Variables
            float s1, s2;
            double hypot;
            //input values of each side

            s1 = float.Parse(txtShortSide1.Text);

            s2 = float.Parse(txtShortSide2.Text);

            //Calculate square of sides

            hypot = CalculateSquared(s1, s2);
            //Show the answers
            DisplayResults(hypot);   
        }
        double CalculateSquared(float sq1,  float sq2)
        {
            return Math.Sqrt((sq1 * sq1) + (sq2 * sq2));
        }    


        void DisplayResults(double hypot)
        {
            txtHypotenuse.Text = hypot.ToString();
        }
        private void txtShortSide1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShortSide2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHypotenuse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
