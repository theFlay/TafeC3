using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

// Peter Halligan, BigBooleans, Sprint One
// Date: 27/10/22
// Version: 1.1
// Astro Pro
// Generates an array of randomised data to simulate neutrino measurements in low atmosthphere
// Inputs, Processes, Outputs


namespace AstroProApp
{
    public partial class Form1 : Form
    {
        //set empty array with length of 24
        int[] dataArray = new int[24];

        public Form1()
        {
            InitializeComponent();
        }
        public void refresher()
        {
            // Function to refresh listbox and array whgen called by sorting both
            #region
            SortFun();
            listBoxMain.Items.Clear();
            foreach (int i in dataArray)
            {
                listBoxMain.Items.Add(i);
            }
            #endregion
        }
        public static bool BinarySearchDisplay(int[] myArray, int key, out int index)
        {
            /// Binary Search Method.
            #region
            /// <param name="myArray">The array of values.</param>
            /// <param name="key">The key to search for.</param>
            /// <param name="index">The array index if key was found, -1 otherwise.</param>
            /// <returns>true if key found, false otherwise.</returns>

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
            #endregion
        }


        public void SortFun()
        {
            //Sort Function for the Array
            #region
            listBoxMain.Items.Clear();
            //initial variables
            int tempBubble = 0;

            //sets index for first number
            for (int left = 0; left < dataArray.Length - 1; left++)
            {
                //sets index for second number
                for (int right = 0; right < dataArray.Length - 1; right++)
                {
                    //compares the two
                    if (dataArray[right] > dataArray[right + 1])
                    {
                        //if if 1<2 move 1 over 2 via temp var
                        tempBubble = dataArray[right + 1];
                        dataArray[right + 1] = dataArray[right];
                        dataArray[right] = tempBubble;
                    }
                }
            }
            foreach (int f in dataArray)
            {
                listBoxMain.Items.Add(f);
            }
            #endregion
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            //clears list box and sets a range for random
            #region
            listBoxMain.Items.Clear();
            Random randNum = new Random();
            //loops array and sets each index as a number then puts in in listbox
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = randNum.Next(0, 101);
                listBoxMain.Items.Add(dataArray[i]);
            }
            refresher();
            #endregion
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //calls refresher on sort button
            refresher();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //Calls Binary search function on array
            #region
            refresher();
            if (string.IsNullOrWhiteSpace(textBoxMain.Text))
            {
                MessageBox.Show("Not Found. Please enter value in text box");
                statusStrip1.Text = "Search Failed";
                return;
            }
            //Call the function and store the results in a variable
            int key = int.Parse(textBoxMain.Text);
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
            refresher();
            #endregion
        }
        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //allows use of the listbox current selection
            #region
            foreach (var item in listBoxMain.SelectedItems)
            {
                textBoxMain.Text = item.ToString();
            }
            #endregion
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            #region
            {
                //updates the selected item with textbox.text
                int selectedIndex;
                int newItem;
                selectedIndex = listBoxMain.SelectedIndex;
                statusStrip1.Text = "Updating entry";
                statusStrip1.Refresh();

                if (int.TryParse(textBoxMain.Text, out newItem))
                {
                    if (String.IsNullOrEmpty(textBoxMain.Text))
                    {
                        MessageBox.Show("Can not add/edit null");
                        return;
                    }
                    else
                    {
                        listBoxMain.Items.Insert(selectedIndex, newItem);
                        dataArray[selectedIndex] = newItem;
                        listBoxMain.Items.Clear();
                        foreach (int f in dataArray)
                        {
                            listBoxMain.Items.Add(f);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, Please try again.");
                    return;
                }
            }
            refresher();
            #endregion
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxOut1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            //calculates the Mid-Extreme of the array
            #region
            SortFun();
            double min = dataArray[0];
            int max = dataArray[23];
            double midEx = (max + min)/2;
            textBoxOut1.Text = $"Mid Extreme = {midEx.ToString("F")}";
            refresher();
            #endregion
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //Calculates the Mode of the array
            #region
            SortFun();
            int mode = 0;
            int max = 0;
            var counts = new Dictionary<int, int>();
            foreach (int value in dataArray)
            {
                if (counts.ContainsKey(value))
                {
                    counts[value]++;
                }
                else
                {
                    counts.Add(value, 1);
                }
            }
            foreach (KeyValuePair<int, int> count in counts)
            {
                if (count.Value > max)
                    mode = count.Key;
                max = count.Value;
            }
            textBoxOut1.Text = $"Mode is: {mode}";
            refresher();
            #endregion
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            //Calculates the Average of the array
            #region
            SortFun();
            double mathSum = 0;
            foreach (int i in dataArray)
            {
                mathSum = mathSum + i;
            }
            double mathAverage = mathSum / 24;
            textBoxOut1.Text = $"Average = {mathAverage.ToString("F")}";
            refresher();
            #endregion
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            //Calculates the Range of the Array
            #region
            SortFun();
            double min = dataArray[0];
            double max = dataArray[23];
            double range = max - min;
            textBoxOut1.Text = $"Range = {range.ToString("F")}";
            refresher();
            #endregion
        }
    }
}
