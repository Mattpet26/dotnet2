using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace MultiBracketValidation
{
    public class MultiBracket
    {
        /// <summary>
        /// Returns a bool if the brackets open and close properly.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool MultiBracketValid(string input)
        {
            //we will pop each item off the stack, adding it to our new array
            DataStructures.Stack<char> stack = new DataStructures.Stack<char>();

            bool result = false;

            foreach (char character in input)
            {
                if (character == '{' || character == '[' || character == '(')
                {
                    stack.Push(character);
                }else if (character == '}' || character == ']' || character == ')')
                {
                    char toPop = stack.Pop();
                    if (toPop - character > 0)
                    {
                        return result;
                    }
                }
            }

            return stack.IsEmpty();
        }
        // { [ ) ]

    }


}
