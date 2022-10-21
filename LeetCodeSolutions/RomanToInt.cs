using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdventOfCode2020
{
    public partial class RomanToInt : Form
    {
        public RomanToInt()
        {
            InitializeComponent();
        }

        public int ReturnIntValue(string s)
        {
            string stringToConvert = s.ToUpper();
            
            IDictionary<string, int> romanValues = new Dictionary<string, int>();
            
            romanValues.Add("I", 1);
            romanValues.Add("V", 5);
            romanValues.Add("X", 10);
            romanValues.Add("L", 50);
            romanValues.Add("C", 100);
            romanValues.Add("D", 500);
            romanValues.Add("M", 1000);

            int CumulativeInt = 0;

            //loop through stringToConvert
            // Special cases IV, IX, XL, XC, CD, CM 

            if (stringToConvert.Contains("IV"))
            {
                stringToConvert = stringToConvert.Replace("IV", string.Empty);
                CumulativeInt += 4;
            }

            if (stringToConvert.Contains("IX"))
            {
                stringToConvert = stringToConvert.Replace("IX", string.Empty);
                CumulativeInt += 9;
            }

            if (stringToConvert.Contains("XL"))
            {
                stringToConvert = stringToConvert.Replace("XL", string.Empty);
                CumulativeInt += 40;
            }

            if (stringToConvert.Contains("XC"))
            {
                stringToConvert = stringToConvert.Replace("XC", string.Empty);
                CumulativeInt += 90;
            }

            if (stringToConvert.Contains("CD"))
            {
                stringToConvert = stringToConvert.Replace("CD", string.Empty);
                CumulativeInt += 400;
            }

            if (stringToConvert.Contains("CM"))
            {
                stringToConvert = stringToConvert.Replace("CM", string.Empty);
                CumulativeInt += 900;
            }

            int size = stringToConvert.Length;

            for (int i = 0; i < size; i++)
            {
                CumulativeInt += romanValues[stringToConvert[i].ToString()];
            }

            Debug.WriteLine(CumulativeInt);
            return CumulativeInt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Store symbols and values
            // store input
            // split input string into array
            // Find special characters first, then remove from array, else add up
            ReturnIntValue("MCMXCIV");
            
        }
    }
}
