using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordList = new Dictionary<string, int>();

            string[] arr = new string[] { "All", "work", "and", "no", "play", "makes", "for", "no", "work", "no","fun","and","no", "results" };

            //foreach word in arr
            foreach(string word in arr)
            {
                int count = 0;
                if (wordList.ContainsKey(word))
                {
                    continue; //continue the foreach loop not the for loop, skip the one below
                }
                for(int i=0; i < arr.Length; i++)
                {
                    if (word.Equals(arr[i]))
                    {
                        count++;
                    }
                }
                wordList.Add(word, count);
            }

            List<KeyValuePair<string, int>> myList = wordList.ToList();

            myList.Sort(
                delegate (KeyValuePair<string, int> pair1,
                KeyValuePair<string, int> pair2)
                {
                    return pair1.Value.CompareTo(pair2.Value);
                }
            );

            Console.WriteLine(myList[myList.Count-1]);

            //create count

            //if wordlist contains this word as the key, continue

            //loop thr the arr
            //if word == arr[i] - if any matching word
            //count++ - increase occurrence

            //set word as key and value as count

            //sort dictionary and display the top occurrence

        }
    }
}
