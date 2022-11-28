using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
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
            toolStripStatusLabel1.Text = "Welcome, Please Generate";
            statusStrip1.Refresh();

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
                dataArray[i] = randNum.Next(10, 100);
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
            toolStripStatusLabel1.Text = "Data Generated";
            statusStrip1.Refresh();
            #endregion
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            //calls refresher on sort button
            #region
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
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
                MessageBox.Show("Please Generate Data First");
                return;
            }
            refresher();
            toolStripStatusLabel1.Text = "Searching";
            statusStrip1.Refresh();
            try
            {
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
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a valid Int to search for");
            }

            #endregion
        }
        private void buttonSeqSearch_Click(object sender, EventArgs e)
        {
            //Sequential Search of Items in array
            #region
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
            }
            bool searchBool = true;
            toolStripStatusLabel1.Text = "Searching";
            statusStrip1.Refresh();
            try
            {
                int finding = int.Parse(textBoxMain.Text);

                int leng = dataArray.Length;

                if (string.IsNullOrWhiteSpace(textBoxMain.Text))
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
                        MessageBox.Show("Item is in list");
                        toolStripStatusLabel1.Text = "Item Found";
                        statusStrip1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Item is NOT in list");
                        toolStripStatusLabel1.Text = "Item Not Found";
                        statusStrip1.Refresh();
                    }
                    toolStripStatusLabel1.Text = "Search Complete";
                    statusStrip1.Refresh();
                    this.ActiveControl = textBoxMain;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Must search for Int ");
            }
            #endregion
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
                bool editPass = false;
                if (hasGen == false)
                {
                    MessageBox.Show("Please Generate Data First");
                    return;
                }
                //updates the selected item with textbox.text
                int selectedIndex;
                int newItem;
                selectedIndex = listBoxMain.SelectedIndex;
                toolStripStatusLabel1.Text = "Updating entry";
                statusStrip1.Refresh();
                try
                {
                    if (int.TryParse(textBoxMain.Text, out newItem))
                    {
                        if (String.IsNullOrEmpty(textBoxMain.Text))
                        {
                            MessageBox.Show("Can not add/edit null");
                            editPass = false;
                            return;
                        }
                        if (int.Parse(textBoxMain.Text) <= 9 || (int.Parse(textBoxMain.Text) >= 100))
                        {
                            MessageBox.Show("Number Range is 10 to 90");
                            editPass = false;
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
                            editPass = true;
                        }
                    }
                    else
                    {
                        editPass = false;
                    }
                    refresher();
                    if (editPass == false)
                    {
                        MessageBox.Show("Error, Please try again.");
                        toolStripStatusLabel1.Text = "Edit Failed";
                        statusStrip1.Refresh();
                    }
                    if (editPass == true)
                    {
                        toolStripStatusLabel1.Text = "Edit Completed";
                        statusStrip1.Refresh();
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Error please select something to edit");
                    toolStripStatusLabel1.Text = "OutOfRangeException";
                    statusStrip1.Refresh();
                }
                
            }
            #endregion
        }

        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            //calculates the Mid-Extreme of the array
            #region
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
            }
            SortFun();
            double midEx = (dataArray.Max() + dataArray.Min())/2;
            textBoxOut1.Text = $"Mid Extreme = {midEx.ToString("F")}";
            refresher();
            toolStripStatusLabel1.Text = "Mid Extreme Calculation Complete";
            statusStrip1.Refresh();
            #endregion
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            //Finds the Mode of the array
            #region
            //checks if data has been Gen'd
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
            }
            SortFun();

            //sets the arrays for working in
            Dictionary<int, int> modecount = new Dictionary<int, int>();
            int[] modes = new int[24];
            //find the mode(s) by saving each item in the list into a dictionary where the dic key is the value in the list and the dic value is the amount of times it occurred
            foreach (int element in dataArray)
            {
                if(modecount.ContainsKey(element))
                    modecount[element]++;
                else
                    modecount.Add(element, 1);
            }
            //saves all modes to a new LIST for ease of printing
            try
            {
                int listItem = 1;
                foreach (KeyValuePair<int, int> item in modecount)
                {
                    if (item.Value == modecount.Values.Max())
                    {
                        modes[listItem] = item.Key;
                        listItem++;
                    }
                }
                //sorts the array without zeros
                var nonZeroes = modes.Where(x => x != 0);
                //outputs the modes (without the list nulls)
                if (nonZeroes.Count() >= 24)
                {
                    //if the list is filled with none zero's then the whole list is the mode meaning there is no true mode.
                    //this if is an error catch to stop that
                    textBoxOut1.Text = "No mode Found";
                }
                else
                {
                    //outputs the mode and its count
                    textBoxOut1.Text = "Mode(s): " + String.Join(", ", nonZeroes) + " Count: " + modecount.Values.Max();
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                //catchs out of range that happens when there is no mode
                textBoxOut1.Text = "No mode Found";
            }
            #endregion
        }
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            //Calculates the Average of the array
            #region
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
            }
            SortFun();
            double mathSum = 0;
            foreach (int element in dataArray)
            {
                mathSum = mathSum + element;
            }
            double mathAverage = mathSum / dataArray.Length;
            textBoxOut1.Text = $"Average = {mathAverage.ToString("F")}";
            refresher();
            toolStripStatusLabel1.Text = "Average Calculation Complete";
            statusStrip1.Refresh();
            #endregion
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            //Calculates the Range of the Array
            #region
            if (hasGen == false)
            {
                MessageBox.Show("Please Generate Data First");
                return;
            }
            SortFun();
            double range = dataArray.Max() - dataArray.Min();
            textBoxOut1.Text = $"Range = {range.ToString("F")}";
            refresher();
            toolStripStatusLabel1.Text = "Range Calculation Completed";
            statusStrip1.Refresh();
            #endregion
        }

        //unused methods
        #region
        private void labelData_Click(object sender, EventArgs e)
        {

        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void range_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void textBoxOut1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
