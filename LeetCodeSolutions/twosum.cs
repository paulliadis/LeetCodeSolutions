using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AdventOfCode2020
{
    public partial class twosum : Form
    {
        public twosum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 2,5,5,11};
            int[] returned = BruteForce(nums, 10);

            for (int p = 0; p < returned.Length; p++)
            {
                Console.WriteLine(returned[p]);
            }


        }

        private int[] BruteForce(int[] nums, int target)
        {
            int[] returnIndices = { 0, 0 };

            int lowerIndex = 0;

            while (lowerIndex < nums.Length)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[lowerIndex] + nums[i] == target)
                    {
                        returnIndices[0] = lowerIndex;
                        returnIndices[1] = i;
                        if(lowerIndex != i)
                        {
                            return returnIndices;
                        }
                        
                    }
                }
                lowerIndex++;
            }
            return returnIndices;
        }

        private int[] FindIndices(int[] nums, int target)//int[]
        {
            int[] returnIndices = { 0, 0 };
            int nextLowest = 0;

            //Find closest in nums without going over (binary search)
            //Loop through the rest until target

            var sortedNums = nums.OrderBy(x => x).ToArray();

            int myIndex = Array.BinarySearch(sortedNums, target);

            if (myIndex < 0)
            {
                nextLowest = ~myIndex - 1; // Return index of the next lowest Roman Numeral in the list

                returnIndices[0] = Array.IndexOf(nums, sortedNums[nextLowest]);

                for (int i = 0; i < ~myIndex; i++)
                {
                    if (sortedNums[i] + sortedNums[nextLowest] == target)
                    {
                        if (sortedNums[i] == sortedNums[nextLowest])
                        {

                            for (int z = i + 1; z < ~myIndex; z++)
                            {
                                if (sortedNums[z] == sortedNums[nextLowest])
                                {
                                    returnIndices[1] = z;
                                }
                            }
                        }
                        else
                        {
                            returnIndices[1] = Array.IndexOf(nums, sortedNums[i]);
                        }
                        return returnIndices;
                    }

                }
            }
            else
            {
                returnIndices[0] = Array.IndexOf(nums, target);
                returnIndices[1] = Array.LastIndexOf(nums, target);

            }

            
            return returnIndices;
        }
    }
}
