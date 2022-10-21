using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class MergeAccounts : Form
    {
        public MergeAccounts()
        {
            InitializeComponent();
        }

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            return accounts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //https://www.dotnetperls.com/nested-list#:~:text=A%20List%20can%20have%20elements%20of%20List%20type.,Lists%20are%20not%20by%20default%20multidimensional%20in%20C%23.
            //https://www.c-sharpcorner.com/uploadfile/puranindia/jagged-arrays-in-C-Sharp-net/#:~:text=A%20jagged%20array%20in%20C%23%20is%20an%20array,the%20length%20of%20each%20array%20index%20can%20differ.

            //string[][] mergedJaggedArray = new string[1000][];

            List<List<string>> mergedList = new List<List<string>>();

            string[][] jaggedArray = new string[][]
            {
                new string[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new string[] { "John", "johnsmith@mail.com","john00@mail.com" },
                new string[] { "Mary", "mary@mail.com"},
                new string[] { "John", "johnnybravo@mail.com"}

            };

            // First sort by name aka jaggedArray[i][0]
            // While first name = previous name, compare emails
            // If 2 emails match, merge, else write unique

            const int headerIndex = 0;
            string previousName = "";

            List<string> uniqueEmails = new List<string>(10);

            int m = 0;

            // Must have matching name and 1 matching email address to merge,
            foreach (var row in jaggedArray.OrderBy(r => r[headerIndex]))
            {

                if (previousName == row[0])
                {
                    /*************************************
                     *   New idea:
                     *   maybe find a match, then call a merge
                     *   function to merge them
                     *   ************************************/

                    for (int n = 1; n < row.Length; n++)
                    {
                        //Need to match at least once on email
                        //Console.WriteLine("row n=" + row[n] );
                        if (uniqueEmails.Contains(row[n]) == false)
                        {
                            uniqueEmails.Add(row[n]);
                        }
                    }

                }
                else
                {
                    if (previousName != "")
                    {
                        Console.WriteLine("change");
                        m = 0;
                    }

                    for (int n = 0; n < row.Length; n++)
                    {
                        uniqueEmails.Add(row[n]);
                    }

                    m++;

                    mergedList.Add(uniqueEmails);
                    //clear out uniqueEmails
                }

                previousName = row[0];


                //Console.WriteLine(string.Join(",", row));

            }

            foreach (string a in uniqueEmails)
               Console.WriteLine(a);
            //Console.WriteLine("end");

            //for (int i = 0; i < jaggedArray.Length; i++) // Outer array
            //{
            //    //System.Console.Write("Element({0}): ", i + 1);

            //    for (int j = 0; j < jaggedArray[i].Length; j++) // Inner array
            //    {
            //        //System.Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    System.Console.WriteLine();
            //}

        }
    }
    
}
