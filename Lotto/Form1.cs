/* Ben Lawlor 2020
DkIT Higher Diploma in Science in Computing */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        //2 integer arrays, 
        //one for displaying the numbers in ascending order
        //and another for the order they were generated in.
        public int[] lotto = new int[6];
        public int[] unorganized = new int[6];

        int entries = 0;

        public Lotto()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //using a for-loop to generate 6 random lottery numbers between 1 and 47
            numbersListBox.Items.Clear();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                int number = random.Next(1, 48);

                //if the lotto array already has this number, we don't add it
                //and we run the loop an extra time
                if (lotto.Contains(number))
                {
                    i--;
                }

                //otherwise we add it to both arrays
                else
                {
                    lotto[i] = number;
                    unorganized[i] = number;
                }
            }

            //If the ascending order checkbox is checked before we click generate,
            //the numbers will automatically be organised.
            //However we can still see the original order by unchecking the box
            //because we have used the two arrays.
            if (AscendingCheckbox.Checked)
            {
                Array.Sort(lotto);
            }
            
            //We use this method to clean up and then populate the numbers listbox
            //in a centered format
            PopulateNumbersListBox(lotto);

            entries++;
            if (entries % 7 == 0)
            {
                MessageBox.Show("You won!", "Congratulations");
            }
        }

        private void AscendingCheckbox_CheckedChanged(object sender, EventArgs e)
        {
             if (AscendingCheckbox.Checked && lotto[0] != 0) 
            {
                //If the box to organise the numbers is checked, and if numbers have been generated,
                //we sort the array, clear the list box and re-print the array with its new order.
                Array.Sort(lotto);
                PopulateNumbersListBox(lotto);
            }

             if (AscendingCheckbox.Checked == false && lotto[0] != 0) 
            {
                //If the box is unchecked, we print the numbers in the order that they were generated
                PopulateNumbersListBox(unorganized);                
            }
        }

        private void PopulateNumbersListBox(int[] numbers)
        {
            //We clear and then send the lotto numbers to the list box 
            //as a single string with some spaces between each element, to display them
            //in a single line.
            //These if, else if & else statements do their best to keep the numbers centered.

            numbersListBox.Items.Clear();
            if (numbers[0] >= 10)
            {
                numbersListBox.Items.Add(string.Format("  {0}   {1}   {2}   {3}   {4}   {5}   ", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]));
            }
            else if (numbers[0] < 10 && numbers[1] < 10)
            {
                numbersListBox.Items.Add(string.Format("    {0}   {1}   {2}   {3}   {4}   {5}   ", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]));
            }
            else
            {
                numbersListBox.Items.Add(string.Format("   {0}   {1}   {2}   {3}   {4}   {5}   ", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
