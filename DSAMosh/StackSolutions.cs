using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongFactorial.DSAMosh
{
    public class StackSolutions
    {
        public string reverse(string input)
        {
          var reversed = string.Empty;
          Stack<char> myStack = new Stack<char>();
          foreach (var item in input)
            myStack.Push(item);
          while(myStack.Count > 0)
            reversed += myStack.Pop();
            return reversed;
        }

        public bool validParanthesis(string s)
        {
            Stack<char> stackPara = new Stack<char>();
            foreach (var item in s)
            {
              if(item == '(' || item == '{' || item == '[' )
                stackPara.Push(item);
              if(item == ')' || item == '}' || item == ']' ){
                if(stackPara.Count < 1) return false;
                if(item == ')' && stackPara.Peek() != '(') return false;
                if(item == ']' && stackPara.Peek() != '[') return false;
                if(item == '}' && stackPara.Peek() != '{') return false;
                stackPara.Pop();
              }
            }
            if(stackPara.Count > 0)
              return false;
            return true;
        }

    }
}
