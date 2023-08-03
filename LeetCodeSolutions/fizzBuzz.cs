using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCodeSolutions
{
    public partial class fizzBuzz : Form
    {
        public fizzBuzz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The question is as follows:
            //answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
            //answer[i] == "Fizz" if i is divisible by 3.
            //answer[i] == "Buzz" if i is divisible by 5.
            //answer[i] == i(as a string) if none of the above conditions are true.
            FizzBuzz(15);
        }

        public IList<string> FizzBuzz(int n)
        {
            IList<string> returnlist = new List<string>();

            for(int i = 1; i <= n; i++)
            {
                returnlist.Add(CheckFizzBuzz(i));
            }

            return returnlist;
        }

        public string CheckFizzBuzz(int n)
        {
            string answer = string.Empty;

            if((n%3 == 0) && (n%5==0))
            {
                answer = "FizzBuzz";
            }
            else if(n % 3 == 0){
                answer = "Fizz";
            }
            else if (n % 5 == 0)
            {
                answer = "Buzz";
            }
            else
            {
                answer = n.ToString();
            }

            //System.Diagnostics.Debug.WriteLine(n%3);
            return answer;
        }
    }
}
