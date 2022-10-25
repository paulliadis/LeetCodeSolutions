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
    public partial class arraystringsareequal : Form
    {
        public arraystringsareequal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //************************************************************************************************************************
            //* https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
            //* Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
            //* A string is represented by an array if the array elements concatenated in order forms the string.
            //************************************************************************************************************************

            string[] word1 = { "abc", "d", "defg" };
            string[] word2 = { "abcddefg" };
  
            txtAnswer.Text = ArrayStringsAreEqual(word1 , word2).ToString();
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string concatWord1 = string.Concat(word1);
            string concatWord2 = string.Concat(word2);

            if(concatWord1 == concatWord2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
