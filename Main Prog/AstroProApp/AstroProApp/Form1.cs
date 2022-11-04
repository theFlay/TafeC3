﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
        int[] dataArray = new int[24];
        //set empty array with length of 24

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            //clears list box and sets a range for random
            listBoxMain.Items.Clear();
            Random randNum = new Random();

            //loops array and sets each index as a number then puts in in listbox
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = randNum.Next(0, 101);
                listBoxMain.Items.Add(dataArray[i]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            #region
            listBoxMain.Items.Clear();
            //initial variables
            int tempBubble = 0;

            //sets index for first number
            for ( int left = 0; left < dataArray.Length -1; left++ )
            {
                //sets index for second number
                for (int right = 0; right < dataArray.Length -1; right++ )
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
            foreach( int f in dataArray)
            {
                listBoxMain.Items.Add(f);
            }
            #endregion
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMain.Text))
            {
                MessageBox.Show("Please enter value into text box");
                return;
            }
            int key = int.Parse(textBoxMain.Text);


            //Call the function and store the results in a variable
            int[] dataArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24};
            bool found = BinarySearchDisplay(dataArray, key, out int index);

            if (found)
            {
                MessageBox.Show($"Found. Index = {index} Value = {dataArray[index]}");
                return;
            }
            else
            {
                MessageBox.Show("Not Found.");
            }
        }
        /// <summary>
        /// Binary Search Method.
        /// </summary>
        /// <param name="myArray">The array of values.</param>
        /// <param name="key">The key to search for.</param>
        /// <param name="index">The array index if key was found, -1 otherwise.</param>
        /// <returns>true if key found, false otherwise.</returns>
        public static bool BinarySearchDisplay(int[] myArray, int key, out int index)
        {
            int minIndex = 0;
            int maxIndex = myArray.Length - 1;
            index = -1;
            while (minIndex <= maxIndex)
            {
                index = (minIndex + maxIndex) / 2;
                if (key == myArray[index])
                {
                    return true;
                }
                else if (key < myArray[index])
                {
                    maxIndex = index - 1;
                }
                else
                {
                    minIndex = index + 1;
                }
            }
            return false;
        }


        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
