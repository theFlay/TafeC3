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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

// Peter Halligan, BigBooleans, Sprint One
// Date: 27/10/22
// Version: 1.5
// Astro Pro
// Generates an array of randomised data to simulate neutrino measurements in low atmosthphere
// Inputs, Processes, Outputs


namespace AstroProApp
{
    public partial class Form1 : Form
    {
        //set empty array with length of 24
        int[] dataArray = new int[24];
        bool hasGen = false;

        public Form1()
        {
            InitializeComponent();
        }
        public void refresher()
        {
            // Function to refresh listbox and array when called
            // Sorts the array, deletes list box, re-adds array to list box
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
            //Bubble Sort Function for the Array
            #region
            if (hasGen == false)
            {
                GenData();
            }
            toolStripStatusLabel1.Text = "Sorting Array";
            statusStrip1.Refresh();
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
            statusStrip1.Text = "Array Has been Sorted";
            statusStrip1.Refresh();
            #endregion
        }
        public void GenData()
        {
            //Populates dataArray with 24 random numbers between 0-100
            #region
            toolStripStatusLabel1.Text = "Generating Data";
            statusStrip1.Refresh();
            listBoxMain.Items.Clear();
            Random randNum = new Random();
            //loops array and sets each index as a number then puts in in listbox
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = randNum.Next(0, 101);
                listBoxMain.Items.Add(dataArray[i]);
            }
            hasGen = true;
            toolStripStatusLabel1.Text = "Data Generated";
            statusStrip1.Refresh();
            refresher();
            #endregion
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            //Calls GenData function to randomise list
            #region
            GenData();
            #endregion
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //calls refresher on sort button
            #region
            if (hasGen == false)
            {
                GenData();
            }
            refresher();
            toolStripStatusLabel1.Text = "Listbox and Array Sorted";
            statusStrip1.Refresh();
            #endregion
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //Calls Binary search function on array
            #region
            if (hasGen == false)
            {
                GenData();
            }
            refresher();
            if (string.IsNullOrWhiteSpace(textBoxMain.Text))
            {
                MessageBox.Show("Not Found. Please enter value in text box");
                toolStripStatusLabel1.Text = "Search Failed";
                statusStrip1.Refresh();
                return;
            }
            //Call the function and store the results in a variable
            int key = int.Parse(textBoxMain.Text);
            bool found = BinarySearchDisplay(dataArray, key, out int index);
            if (found)
            {
                MessageBox.Show($"Found. Index = {index} Value = {dataArray[index]}");
                toolStripStatusLabel1.Text = "Search Passed. Item Found";
                statusStrip1.Refresh();
                return;
            }
            else
            {
                MessageBox.Show("Not Found.");
                toolStripStatusLabel1.Text = "Search Passed. Item Not Found";
                statusStrip1.Refresh();
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
            //Edit an item in the Array
            #region
            {
                if (hasGen == false)
                {
                    GenData();
                }
                //updates the selected item with textbox.text
                int selectedIndex;
                int newItem;
                selectedIndex = listBoxMain.SelectedIndex;
                toolStripStatusLabel1.Text = "Updating entry";
                statusStrip1.Refresh();

                if (int.TryParse(textBoxMain.Text, out newItem))
                {
                    if (String.IsNullOrEmpty(textBoxMain.Text))
                    {
                        MessageBox.Show("Can not add/edit null");
                        toolStripStatusLabel1.Text = "Edit Failed";
                        statusStrip1.Refresh();
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
                        toolStripStatusLabel1.Text = "Edit Completed";
                        statusStrip1.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Error, Please try again.");
                    toolStripStatusLabel1.Text = "Search Failed";
                    statusStrip1.Refresh();
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
            if (hasGen == false)
            {
                GenData();
            }
            SortFun();
            double midEx = (dataArray.Max() + dataArray.Min())/2;
            textBoxOut1.Text = $"Mid Extreme = {midEx.ToString("F")}";
            toolStripStatusLabel1.Text = "Mid Extreme Calculation Complete";
            statusStrip1.Refresh();
            refresher();
            #endregion
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //Finds the Mode of the array
            #region
            SortFun();
            if (hasGen == false)
            {
                GenData();
            }
            string seperator = ", ";
            var mostFrequentValues = new HashSet<int>();
            int maxCount = 0;
            // Prepare our frequency tracking dictionary, max frequency count, and frequent values setvar
            var frequencyTrack = new Dictionary<int, int>();
            foreach (int value in dataArray)
            {
                int curCount = 1;
                // If we already know about this number then we should
                // update the frequency to existing
                if (frequencyTrack.TryGetValue(value, out int existingCount))
                {
                    curCount = existingCount +1;
                }
                // set the frequency for this value
                frequencyTrack[value] = curCount;

                // if the frequency is higher than the previously known value
                // we have a new winner, so we should record the new frequency
                // and clear the winning list of numbers before finally adding
                // the current value
                if (curCount > maxCount)
                {
                    maxCount= curCount;
                    mostFrequentValues.Clear();
                    mostFrequentValues.Add(value);
                }
                // if the count matches the current max then we should
                //add it as another winner
                else if (curCount == maxCount)
                {
                    mostFrequentValues.Add(value);
                }
                // we don't care about lesser frequencies so we don't do anything here
                // print the result(s)
                textBoxOut1.Text = "Mode(s): " + string.Join(seperator, mostFrequentValues);
                toolStripStatusLabel1.Text = "Mode Calculation Complete";
                statusStrip1.Refresh();
                refresher();
                #endregion
            }
        }
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            //Calculates the Average of the array
            #region
            if (hasGen == false)
            {
                GenData();
            }
            SortFun();
            double mathSum = 0;
            foreach (int i in dataArray)
            {
                mathSum = mathSum + i;
            }
            double mathAverage = mathSum / dataArray.Length;
            textBoxOut1.Text = $"Average = {mathAverage.ToString("F")}";
            toolStripStatusLabel1.Text = "Average Calculation Complete";
            statusStrip1.Refresh();
            refresher();
            #endregion
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            //Calculates the Range of the Array
            #region
            if (hasGen == false)
            {
                GenData();
            }
            SortFun();
            double range = dataArray.Max() - dataArray.Min();
            textBoxOut1.Text = $"Range = {range.ToString("F")}";
            toolStripStatusLabel1.Text = "Range Calculation Completed";
            statusStrip1.Refresh();
            refresher();
            #endregion
        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }
         
        private void buttonSeqSearch_Click(object sender, EventArgs e)
        {
            //Sequential Search of Items in array
            #region
            if (hasGen == false)
            {
                GenData();
            }
            bool searchBool = true;
            toolStripStatusLabel1.Text = "Preforming Linear Search";
            statusStrip1.Refresh();
            int.TryParse(textBoxMain.Text, out int finding);
            int leng = dataArray.Length;

            if (textBoxMain.Text == "")
            {
                MessageBox.Show(" Can not search for null");
                toolStripStatusLabel1.Text = "Search Error";
                statusStrip1.Refresh();
                textBoxMain.Clear();
                this.ActiveControl = textBoxMain;
            }
            else
            {
                SortFun();
                for (int i = 0; i < leng; i++)
                {
                    if (dataArray[i] == finding)
                    {
                        searchBool = false;
                    }
                }
                if (searchBool == false)
                {
                    MessageBox.Show("Plate is in list");
                    toolStripStatusLabel1.Text = "Item Found";
                    statusStrip1.Refresh();
                }
                else
                {
                    MessageBox.Show("Plate is NOT in list");
                    toolStripStatusLabel1.Text = "Item Not Found";
                    statusStrip1.Refresh();
                }
                toolStripStatusLabel1.Text = "Search Complete";
                statusStrip1.Refresh();
                this.ActiveControl = textBoxMain;
            }
            #endregion
        }
    }
}
