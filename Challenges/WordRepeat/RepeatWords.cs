using Challenges.ArrayChallenges;
using System;
using System.Collections.Generic;

namespace Challenges
{
    public class RepeatWords
    {
        public static string RepeatedWord(string stringOfWords)
        {
            HashSet<string> Words = new HashSet<string>();

            char[] delimiters = { ',', '.', ';', ':', ' ' };
            foreach(string s in stringOfWords.ToLower().Split(delimiters))
            {
                if (Words.Contains(s))
                    return s;
                Words.Add(s);
            }


            return "";
        }

        
    }
}
