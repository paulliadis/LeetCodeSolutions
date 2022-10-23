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
    public partial class getmismatch : Form
    {
        public getmismatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/
            int[] nums = { 1, 2, 2, 4 };

            int[] solution = FindErrorNums(nums);
            for(int i = 0; i < solution.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(i);
            }
        }

        public int[] FindErrorNums(int[] nums)
        {
            int[] answer = { 2, 2 };

            Array.Sort(nums);

            int min = 1;
            int max = nums.Length;

            IEnumerable<int> whatNumsShouldBe = Enumerable.Range(min, max);

            // Find missing number
            var diff = whatNumsShouldBe.Except(nums);

            foreach (int i in diff)
            {
                answer[1] = i;
            }

            //Find duplicate
            var duplicates = nums.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(y => y.Key)
                            .ToList();

            foreach (int i in duplicates)
            {
                answer[0] = i;
            }


            return answer;
        }

        public int[] FindErrorNumsBruteForce(int[] nums)
        {
            // This solution worked but took too long to run
            // on larger sets of numbers

            int[] answer = { 0, 0 };

            Array.Sort(nums);

            int min = nums.Min();
            int max = nums.Length;

            // IEnumerable<int> whatNumsShouldBe = Enumerable.Range(1, max);
            if (nums.Length == 2)
            {
                int[] expected = { 1, 2 };

                if (nums[0] == nums[1])
                {
                    answer[0] = nums[0];
                    //    answer[1] = nums.Length;
                }
                //else
                //{
                foreach (int nummy in expected)
                {
                    var filtered = from x in nums
                                   where x == nummy
                                   select x;

                    if (filtered.Count() == 0)
                    {
                        answer[1] = nummy;
                    }
                }
                //}
                return answer;
            }
            else
            {
                IEnumerable<int> whatNumsShouldBe = Enumerable.Range(1, max);

                int[] array = { 0, 0 };

                array = whatNumsShouldBe.ToArray();

                foreach (int nummy in whatNumsShouldBe)
                {

                    var filtered = from x in nums
                                   where x == nummy
                                   select x;

                    if (filtered.Count() == 0)
                    {
                        answer[1] = nummy;
                    }
                    else if (filtered.Count() > 1)
                    {
                        answer[0] = nummy;
                    }

                }
                return answer;
            }

        }
    }
}
