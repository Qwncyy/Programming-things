using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCalculatoriii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            //Variables

            float roomLength;
            float roomWidth;
            float roomArea;
            float roomHeight;
            float roomVolume;

            //input length
            roomLength = float.Parse(textBox1.Text);

            //input width
            roomWidth = float.Parse(textBox2.Text);
            //calculate room area
            roomArea = roomLength * roomWidth;
            //output room area
            textBox3.Text = roomArea.ToString();

            //input room height
            roomHeight = float.Parse(txtRoomHeight.Text);

            //calculate room volume
            roomVolume = roomLength * roomWidth * roomHeight;

            //ouput room volume
            txtRoomHeight.Text = roomVolume.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
