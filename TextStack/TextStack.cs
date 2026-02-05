using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStack
{
    internal class TextStack
    {
        private int maxSize;
        private List<string> stackList;
        private int top;
        public TextStack()
        {
            stackList = new List<string>(); 
            top = -1;
        }
        public void Push(string stack)//Push new element top of the list.
        {
            stackList.Add(stack);
            top++;
        }
        public string Pop()//Remove top element and return its value.
        {
                
            string popElement = stackList[top];
            stackList.RemoveAt(top--);
            return popElement;
            
            
        }
        public string Peek()//Return top element value.
        {
            return stackList[top];
        }
        public bool isEmpty()
        {
            return top==-1;
        }
        public bool isFull()
        {
            return maxSize-1 == top;
        }
    }
}
