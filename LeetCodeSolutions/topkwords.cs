using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode2020
{
    public partial class topkwords : Form
    {
        public topkwords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<string> topKWords = new List<string>();
            string[] words = { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };

            topKWords = TopKFrequent(words, 4);

            foreach(string k in topKWords)
            {
                System.Diagnostics.Debug.WriteLine(k);
            }
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            IList<string> returnIList = new List<string>();

            List<Tuple<int, string>> romanValues = new List<Tuple<int, string>>();

            Array.Sort(words);

            string prevWord = "";
            int wordCount = 1;
            bool initialPass = true;

            foreach(string word in words)
            {
                if (word != prevWord)
                {

                    if (initialPass == false)
                    {
                        romanValues.Add(Tuple.Create<int, string>(wordCount, prevWord));
                        wordCount = 1;
                    }
                    else
                    {
                        initialPass = false;
                    }

                    prevWord = word;
                }
                else{  
                    wordCount++;
                }
            }
            romanValues.Add(Tuple.Create<int, string>(wordCount, prevWord));

            var sortedList = romanValues.OrderByDescending(i => i.Item1).ThenBy(p => p.Item2).Take(k).ToList();

            foreach (var p in sortedList)
            {
                returnIList.Add(p.Item2);
            }


            return returnIList;
        }
    }
}
