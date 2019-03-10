using System;

namespace foreach_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            //  Array for whitelist check
            string[] word_list = new string[] { "a", "ab", "about", "at", "end", "word" };

            string word = "banana";

            void check_word(string f)
            {
                int depth = 0;
                int total_words = word_list.Length;

                foreach (string r in word_list)
                {
                    depth += 1;
                    if (r == word)
                    {
                        Console.WriteLine("Success! Message approved!" + "\n");
                        break;
                    }
                    if((depth == total_words))
                    {
                        Console.WriteLine("One of your words didn't pass inspection.\n");
                    }
                    
                }
            }

            //  Testing error message
            check_word(word);

            //  "Success!" Message.
            word = "word";
            check_word(word);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
           
        }
    }
