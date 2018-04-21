//	Will's positive chat filter and parsing agent
/*	
	The idea is to create a list of words and phrases that are allowed on my messaging service.
*/

using System;

namespace foreach_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            //  Array for whitelist check - this may later be a class and several objects:
            string[] word_list = new string[] { "a", "ab", "about", "at", "end", "word" };

            //  First word to check - replace with user input:
            string word = "banana";

            //  Check the words for matches:
            void check_word(string f)
            {
                //  This will let us know when we have checked the entire list of words and later, links:
                int depth = 0;  //  Also, this resets for each word searched.

                //  This was easier to write, I guess:
                int total_words = word_list.Length;

                //  For each word in the word list, check if the input word matches:
                foreach (string r in word_list)
                {
                    //  This will keep cound of how many words we have looked at.
                    depth += 1;

                    //  If our supplied word matches one of the words in our dictionary...:
                    if (word == r)
                    {
                        Console.WriteLine("Success! Message approved!" + "\n");
                        break; //   Exit loop and begin next part of the program.
                    }

                    //  If we reached the end of the list and still don't have a match...:
                    if ((depth == total_words) && (word != r))
                    {
                        Console.WriteLine("One of your words didn't pass inspection.\n");
                    }

                }
            }

            //  Testing error message
            check_word(word);

            //  Testing "Success!" Message.
            word = "word";
            check_word(word);

            //  Keep the window open until you press a key (thanks derkaderka @ https://social.msdn.microsoft.com/Forums/vstudio/en-US/08163199-0a5d-4057-8aa9-3a0a013800c7/how-to-write-a-command-like-pause-to-console?forum=csharpgeneral):
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
			
			/*	Soon to go somewhere:
			
				List of common variations of certain words (for which I want specific messages):
				
				string[] cmocw1 = new string[] {
					abit, luv, wittle, wuv
				}
				
				List of common variations of certain words (which I want to pass my filter):
				
				string[] cmocw2 = new string[] {
					burger
				}
				
			*/
        }

    }
}
