using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Peter Halligan, BigBooleans, Sprint One
// Date: 27/10/22
// Version: 1.0
// Astro Pro
// Generates an array of randomised data to simulate neutrino measurements in low atmosthphere
// Inputs, Processes, Outputs


namespace AstroProApp
{
    public partial class Form1 : Form
    {
        //set empty array with length of 24
        private int[] dataArray = new int[24];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            #region
            //initial variables
            int tempBubble = 0;

            //sets index for first number
            for ( int left = 0; left < dataArray.Length; left++ )
            {
                //sets index for second number
                for (int right = 0; right < dataArray.Length; right++ )
                {
                    //compares the two
                    if (dataArray[right] < dataArray[right +1])
                    {
                        //if if 1<2 move 1 over 2 via temp var
                        tempBubble = dataArray[right + 1];
                        dataArray[right + 1] = dataArray[right];
                        dataArray[right] = tempBubble;
                    }
                }
            }
            #endregion
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
