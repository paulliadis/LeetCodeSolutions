using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class IntToEnglish : Form
    {
        public IntToEnglish()
        {
            InitializeComponent();
        }

        private string returnChunkOfThree(string chunkOfThree)
        {
            string outString = "";
            int intLength = 0;
            intLength = chunkOfThree.Length;

            IDictionary<int, string> englishInts = new Dictionary<int, string>();

            englishInts.Add(0, "");
            englishInts.Add(1, "One");
            englishInts.Add(2, "Two");
            englishInts.Add(3, "Three");
            englishInts.Add(4, "Four");
            englishInts.Add(5, "Five");
            englishInts.Add(6, "Six");
            englishInts.Add(7, "Seven");
            englishInts.Add(8, "Eight");
            englishInts.Add(9, "Nine");
            englishInts.Add(10, "Ten");
            englishInts.Add(11, "Eleven");
            englishInts.Add(12, "Twelve");
            englishInts.Add(13, "Thirteen");
            englishInts.Add(14, "Fourteen");
            englishInts.Add(15, "Fifteen");
            englishInts.Add(20, "Twenty");
            englishInts.Add(30, "Thirty");
            englishInts.Add(40, "Forty");
            englishInts.Add(50, "Fifty");
            englishInts.Add(60, "Sixty");
            englishInts.Add(70, "Seventy");
            englishInts.Add(80, "Eighty");
            englishInts.Add(90, "Ninety");

           if (intLength == 3 && Convert.ToInt32(chunkOfThree.Substring(0,1)) > 0) // If three digits and not with padded 0
           {
               
                outString = englishInts[Convert.ToInt32(chunkOfThree.Substring(0, 1))] + " Hundred";
            }
            else
            {
               
                if (chunkOfThree.Substring(0,2) == "00")
                {
                    chunkOfThree = Convert.ToInt32(chunkOfThree).ToString(); //chop away leading 0 and then convert back to string
                    outString = englishInts[Convert.ToInt32(chunkOfThree)];
                    return outString;
                }
                
            }

            // If teens
            if (chunkOfThree.Substring(1, 1) == "1")
            {
                Debug.WriteLine(Convert.ToInt32(chunkOfThree.Substring(1, 2)));
                if (Convert.ToInt32(chunkOfThree.Substring(1, 2)) <= 15)
                {
                    outString = outString + " " + englishInts[Convert.ToInt32(chunkOfThree.Substring(1, 2))];
                }
                else
                {
                    if (Convert.ToInt32(chunkOfThree.Substring(2, 1)) != 8)
                    {
                        outString = outString + " " + englishInts[Convert.ToInt32(chunkOfThree.Substring(2, 1))] + "teen";
                    }
                    else
                    {
                        outString = outString + " " + englishInts[Convert.ToInt32(chunkOfThree.Substring(2, 1))] + "een";
                    }
                    
                }
            }
            else
            {
                if (Convert.ToInt32(chunkOfThree.Substring(1, 1)) > 0)
                {
                    outString = outString + " " + englishInts[Convert.ToInt32(chunkOfThree.Substring(1, 1) + "0")];
                }

                if (Convert.ToInt32(chunkOfThree.Substring(2, 1)) > 0)
                {
                    outString = outString + " " + englishInts[Convert.ToInt32(chunkOfThree.Substring(2, 1))];
                }
            }
            return outString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myint = Int16.Parse(txtIntToConvert.Text);
            string outString = "";
            if (myint == 0)
            {
                outString = "Zero";
            }
            else
            {
                string inString = string.Empty;
                inString = string.Format("{0:#,##0.##}", myint);

                string[] chunks = inString.Split(',');

                int arrLength = chunks.Length;

                for (int i = 0; i < chunks.Length; i++)
                {
                    if (chunks[i].Length == 1)
                    {
                        chunks[i] = "00" + chunks[i];
                    }
                    else if (chunks[i].Length == 2)
                    {
                        chunks[i] = "0" + chunks[i];
                    }

                    outString += returnChunkOfThree(chunks[i]);

                    if (arrLength == 2)
                    {
                        arrLength = arrLength - 1;
                        if (chunks[i] != "000")
                        {
                            outString = outString + " Thousand ";
                        }
                    }

                    if (arrLength == 3)
                    {
                        arrLength = arrLength - 1;
                        if (chunks[i] != "000")
                        {
                            outString = outString + " Million ";
                        }
                    }

                    if (arrLength == 4)
                    {
                        arrLength = arrLength - 1;
                        outString = outString + " Billion ";
                    }
                }
            }
            txtReturnedRoman.Text = outString.Trim();
        }
    }
}
