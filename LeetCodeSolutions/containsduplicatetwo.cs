using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCodeSolutions
{
    public partial class containsduplicatetwo : Form
    {
        public containsduplicatetwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool answer = ContainsNearbyDuplicate(nums, k);

            System.Diagnostics.Debug.WriteLine(answer);
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {

            int numsPointer = 0; // Stores position in the array of number being observed

            while(numsPointer < nums.Length)
            {
                int foundPosition = Array.IndexOf(nums, nums[numsPointer], numsPointer + 1);

                if((Math.Abs(foundPosition - numsPointer) <= k)&& foundPosition > 0)
                {
                    return true;
                }

                numsPointer++;
            }

            return false;
        }
            

    }
}
