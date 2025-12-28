using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extra_csharp_strings.Level_01
{
    internal class ReplaceWords
        {
            public static void Replace()
            {
                // Input
                Console.Write("Enter a sentence: ");
                string str = Console.ReadLine();
                if (str == null)
                    return;
                Console.Write("Enter word to replace: ");
                string OriginalWord = Console.ReadLine();
                if (OriginalWord == null || OriginalWord.Length == 0)
                    return;
                Console.Write("Enter new word: ");
                string NewWord = Console.ReadLine();
                if (NewWord == null)
                    return;
                char[] res = new char[str.Length * 2];
                int idx = 0;
                for (int i = 0; i < str.Length;)
                {
                    bool match = true;
                    if (i + OriginalWord.Length <= str.Length)
                    {
                        for (int j = 0; j < OriginalWord.Length; j++)
                        {
                            if (str[i + j] != OriginalWord[j])
                            {
                                match = false;
                                break;
                            }
                        }
                    }
                    else
                        match = false;

                    if (match)
                    {
                        for (int k = 0; k < NewWord.Length; k++)
                        {
                            res[idx++] = NewWord[k];
                        }
                        i += OriginalWord.Length;
                    }
                    else
                    {
                        res[idx++] = str[i];
                        i++;
                    }
                }
                // Output
                string fSentence = new string(res, 0, idx);
                Console.WriteLine("Modified : " + fSentence);
            }
        }
    }

