using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//************************************************************************************************************
//* Given an array of strings strs, group the anagrams together. You can return the answer in any order.
//* An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically
//* using all the original letters exactly once.
//*
//* https://leetcode.com/problems/group-anagrams/
//************************************************************************************************************

namespace LeetCodeSolutions
{
    public class anagrams
    {
        public string word { get; set; }
        public string sortedWord { get; set; }
    }

    public partial class groupanagrams : Form
    {
        public groupanagrams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagrams(strs);

        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            ArrayList arrList = new ArrayList();

            List<IList<string>> listOfLists = new List<IList<string>>();

            //Loop through the input array
            for (int i = 0; i < strs.Length; i++)
            {
                //Sort an entry in the array
                string sorted = String.Concat(strs[i].OrderBy(c => c)); 

                //Add each item to the list, along with the "sorted" value of the list
                arrList.Add(
                new anagrams
                {
                    word = strs[i],
                    sortedWord = sorted
                }); ;
            }

            // Group the words together based on the sorted letters in the list
            // because words with the exact list of letters would be "anagrams"

            var query = from anagrams word in arrList
                        orderby word.sortedWord
                        select word;

            string prevOne = "-1";

            List<string> anagramGroup = new List<string>();

            foreach (anagrams s in query)
            {
                // Test if word grouping has changed and not first iteration
                if ((prevOne != s.sortedWord) && (prevOne != "-1"))
                {
                    //Add anagram group to master list of anagrams
                    listOfLists.Add(anagramGroup);

                    //Create a new list of anagrams
                    anagramGroup = new List<string>();

                }

                anagramGroup.Add(s.word);

                prevOne = s.sortedWord;

            }

            listOfLists.Add(anagramGroup);

            return listOfLists;
        }
    }
}
