using System;
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
    public partial class ispangram : Form
    {
        public ispangram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = "jwtucoucmdfwxxqnxzkaxoglszmfrcvjoiunqqausaxxaaijyqdqgvdnqcaihwilqkpivenpnekioyqujrdrovqrlxovcucjqzjsxmllfgndfprctxvxwlzjtciqxgsxfwhmuzqvlksyuztoetyjugmswfjtawwaqmwyxmvo";

            Console.WriteLine(isitpangram(sentence));
        }

        private bool isitpangram(string inputString)
        {
            string data = "abcdefghijklmnopqrstuvwxyz";
            int numberOfLettersFound = 0;

            List<char> alphalist = new List<char>();
            alphalist.AddRange(data);

            bool isitpangram = false;

            //is in list? remove and increment 1 then remove from list
            foreach (char c in inputString)
            {
                if (alphalist.Contains(c))
                {
                    alphalist.RemoveAll(vara => vara == c);
                    numberOfLettersFound++;
                }
            }

            if (numberOfLettersFound > 25)
            {
                isitpangram = true;
            }
            else
            {
                isitpangram = false;
            }

            return isitpangram;
        }
    }
}
