using System;

namespace BridgeLabzTraining.scenario_based.SentenceFormatter
{
    internal class Paragraph_Analyser
    {
        public void Analyser()
        {
            Console.WriteLine("Enter a paragraph:");
            string a = Console.ReadLine();
            count(a);
            int NoOfWords = noOfWords(a);
            Console.WriteLine("The no of Words in Paragrph is " + NoOfWords);
            Console.WriteLine("Enter the word to be replace");
            string old = Console.ReadLine();
            Console.WriteLine("Enter the word to replace the word");
            string newString = Console.ReadLine();
            string b = ReplaceWord(a, old, newString );
            Console.WriteLine(b);
        }
        public void count(string a)
        {
            int count = 0;
            int count1 = 0;
            string s = "";
            string s1 = "";
            foreach (char ch in a)
            {
                if (ch == ' ')
                {
                    if (count > count1)
                    {
                        count1 = count;
                        s1 = s;
                    }
                    // reset for next word
                    count = 0;
                    s = "";
                }
                else
                {
                    count++;
                    s += ch;
                }
            }
            //  Check last word (if string doesn't end with space)
            if (count > count1)
            {
                count1 = count;
                s1 = s;
            }
            Console.WriteLine("The longest word in paragraph is " + s1);
        }
        public int noOfWords(string a)
        {
            int count = 0;
            foreach (char ch in a)
            {
                if (ch == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        public string ReplaceWord(string paragraph, string oldWord, string newWord)
        {
            string res = "";
            string currWord = "";
            for (int i = 0; i < paragraph.Length; i++)
            {
                char ch = paragraph[i];
                if (ch != ' ')
                {
                    currWord += ch;
                }
                else
                {
                    if (currWord == oldWord)
                        res += newWord;
                    else
                        res += currWord;

                    res += " ";
                    currWord = "";
                }
            }
            // Handle last word
            if (currWord == oldWord)
                res += newWord;
            else
                res += currWord;

            return res;
        }
    }
}
