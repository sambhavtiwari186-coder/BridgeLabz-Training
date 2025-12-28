using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.Level_01
{
    internal class WordSplit
    {
            // Method to calculate string length without using Length property
            public int GetStringLength(string text){
            int cnt = 0;
            foreach (char c in text)
            {
                cnt++;
            }
            return cnt;
        }
        // Method to split text into words without using Split()
        public  string[,] SplitWordsAndLengths(string input)
        {
            int length = GetStringLength(input);
            int WordCount = 0;
            bool InWord = false;
            // Count number of words
            for (int i = 0; i < length; i++)
            {
                if (input[i] != ' ' && !InWord)
                {
                    WordCount++;
                    InWord = true;
                }
                else if (input[i] == ' ')
                {
                    InWord = false;
                }
            }
            string[,] res = new string[WordCount, 2];
            int index = 0;
            string CurrWord = "";
            // Extract words
            for (int i = 0; i < length; i++)
            {
                if (input[i] != ' ')
                {
                    CurrWord += input[i];
                }
                else if (CurrWord != "")
                {
                    res[index, 0] = CurrWord;
                    res[index, 1] = GetStringLength(CurrWord).ToString();
                    index++;
                    CurrWord = "";
                }
            }
            // Store last word
            if (CurrWord != "")
            {
                res[index, 0] = CurrWord;
                res[index, 1] = GetStringLength(CurrWord).ToString();
            }
            return res;
        }
        public void SplitAnswer()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            string[,] wordsData = SplitWordsAndLengths(input);
            Console.WriteLine("\nWord\tLength");
            Console.WriteLine("---------------");
            for (int i = 0; i < wordsData.GetLength(0); i++)
            {
                Console.WriteLine(wordsData[i, 0] + "\t" + wordsData[i, 1]);
            }
        }
    }
}



