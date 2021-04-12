using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.MultiBracketChallenge
{
    public class MultiBracketValidationClass
    {
        public static bool CheckBracketBalance(string input)
        {
            Stack<char> stack = new Stack<char>();
            bool hasBracket = false; 

            foreach (char c in input)
            {

                switch (c)
                {
                    case '{':
                        stack.Push(c);
                        hasBracket = true;
                        break;

                    case '[':
                        stack.Push(c);
                        hasBracket = true;
                        break;

                    case '(':
                        stack.Push(c);
                        hasBracket = true;
                        break;

                    case '}':
                        if (!stack.TryPop(out char o) || o != '{')
                        {
                            return false;
                        }

                        break;

                    case ']':
                        if (!stack.TryPop(out o) || o != '[')
                        {
                            return false;
                        }
                           
                        break;

                    case ')':
                        if (!stack.TryPop(out o) || o != '(')
                        {
                            return false;
                        }
                            
                        break;
                }
            }
            if (stack.Count != 0 || !hasBracket)
            {
                return false;
            }
                
            return true;
        }
    }
}


