using System;
using System.Collections;

namespace ConsoleApp2
{

    class Stack
    {
        int top;
        int[] stack = new int[100];

        public Stack()
        {
            top = -1;

        }

        public bool Push(int input)
        {
            if(top >= 100)
            {
                return false;
            }
            else
            {
                stack[++top] = input;
                return true;
            }
        }

        public void Pop()
        {
            if (top >= 0)
            {
                stack[top] = 0;
                top--;
            }

        }

        public int Peek()
        {
            if(top < 0)
            {
                return 0;
            }
            else
            {
                return stack[top];
            }
        }

        public void displayStack()
        {
            for (int i = 0; i < top + 1; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

        public int Count()
        {
            if(top == -1)
            {
                return 0;   
            }
            int j = 0;
            do
            {
                j++;
            } while (stack[j] != 0);

            return j;
        }

            
    }

    //actual program

    class Program
    {
        static void Main(string[] args)
        {
            Stack input = new Stack();

            input.Push(3);
            input.Push(7);
            input.Push(1);
            input.Push(11);
            
            Stack StackTemp = Sort(input);

            StackTemp.displayStack();

        }

        static Stack Sort(Stack input)
        {

            Stack StackTemp = new Stack();

            while (input.Count() != 0)
            {
                int temp = (int)input.Peek();  
                input.Pop();

                while(StackTemp.Count() != 0 && (int)StackTemp.Peek() > temp) //problem
                {
                    input.Push(StackTemp.Peek());
                    StackTemp.Pop();
                }

                if (temp < 10) // to check against the plates attribute i.e is it not the right type.
                {
                    StackTemp.Push(temp);
                }
            }

            return StackTemp;        
        }

    }
}
