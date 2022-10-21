using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class IntToRoman : Form
    {
        public IntToRoman()
        {
            InitializeComponent();
        }

        public string ReturnRomanValue1(int inputInt)
        {
            int myObjectEven = inputInt;
            string returnRoman = "";

            // Dictionary to hold key, values to lookup roman numerals
            IDictionary<int, string> romanValues = new Dictionary<int, string>();

            romanValues.Add(1, "I");
            romanValues.Add(4, "IV");
            romanValues.Add(5, "V");
            romanValues.Add(9, "IX");
            romanValues.Add(10, "X");
            romanValues.Add(40, "XL");
            romanValues.Add(50, "L");
            romanValues.Add(90, "XC");
            romanValues.Add(100, "C");
            romanValues.Add(400, "CD");
            romanValues.Add(500, "D");
            romanValues.Add(900, "CM");
            romanValues.Add(1000, "M");

            //Array list of possible integers used in binary search
            ArrayList myAL = new ArrayList();
            myAL.Add(1);
            myAL.Add(4);
            myAL.Add(5);
            myAL.Add(9);
            myAL.Add(10);
            myAL.Add(40);
            myAL.Add(50);
            myAL.Add(90);
            myAL.Add(100);
            myAL.Add(400);
            myAL.Add(500);
            myAL.Add(900);
            myAL.Add(1000);

            bool loop = true;

            // Recursively call a function that does a binary search until no more values remain
            do
            {
                int index=0;
                try
                {   
                    
                    index = FindMyObject(myAL, myObjectEven); // This calls the binary search and returns the index you want to look up the next lowest roman numeral
                    if (index >= 0)
                    {
                        returnRoman += romanValues[(int)myAL[index]]; // Store value into the answer string 
                        myObjectEven -= (int)myAL[index]; //Subtract away the value of the numeral you just stored
                    }
                    else
                    {
                        loop = false; // Nothing else left, exit loop
                    }
                }
                catch 
                {
                    Console.WriteLine("You have an error");
                }
            } while (loop);

            return returnRoman;
        }

        public static int FindMyObject(ArrayList myList, int myObject)
        {
            int myIndex = myList.BinarySearch(myObject);
            int returnIndex = 0;
            if (myIndex < 0)
            {
                returnIndex = ~myIndex - 1; // Return index of the next lowest Roman Numeral in the list
            }
            else
            {
                returnIndex = myIndex; // You found a match so return the index
            }
            return returnIndex;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string returnedRoman = "";
            string whatToLookup = txtIntToConvert.Text;
            returnedRoman = ReturnRomanValue1(Int16.Parse(whatToLookup));

            txtReturnedRoman.Text = returnedRoman;
        }
    }
}
