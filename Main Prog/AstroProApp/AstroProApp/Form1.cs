using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public static bool BinarySearchDisplay(int[] myArray, int key, out int index)
        {

            /// Binary Search Method.
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
        }


        public void SortFun()
        {
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
            SortFun();
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SortFun();
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
        }

      

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //allows use of the listbox current selection
            foreach (var item in listBoxMain.SelectedItems)
            {
                textBoxMain.Text = item.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {   
            {
                int selectedIndex;
                int newItem;
                selectedIndex = listBoxMain.SelectedIndex;
                statusStrip1.Text = "Updating entry";
                statusStrip1.Refresh();

                if(int.TryParse(textBoxMain.Text, out newItem))
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
        }
               

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxOut1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {

        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            string seperator = ", ";
            var mostFrequentValues = new HashSet<int>();
            int maxCount = 0;
            var frequencyTrack = new Dictionary<int, int>();
            foreach (int value in dataArray)
            {
                int curCount = 1;
                if (frequencyTrack.TryGetValue(value, out int existingCount))
                {
                    curCount = existingCount +1;
                }
                frequencyTrack[value] = curCount;

                if (curCount > maxCount)
                {
                    maxCount= curCount;
                    mostFrequentValues.Clear();
                    mostFrequentValues.Add(value);
                }
                else if (curCount == maxCount)
                {
                    mostFrequentValues.Add(value);
                }
                textBoxOut1.Text = "Mode(s): " + string.Join(seperator, mostFrequentValues);
            }
        }
        private void buttonAverage_Click(object sender, EventArgs e)
        {

        }

        private void buttonRange_Click(object sender, EventArgs e)
        {

        }
    }
}
