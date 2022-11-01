using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack input = new Stack();

            input.Push(5);
            input.Push(2);
            input.Push(9);
            input.Push(11);

            Stack StackTemp = Sort(input);


            for(int i = 0; i < StackTemp.Count + 3; i++)
            {
                Console.WriteLine(StackTemp.Peek());
                StackTemp.Pop();
            }

        }

        static Stack Sort(Stack input)
        {

            Stack StackTemp = new Stack();

            while(input.Count != 0)
            {
                int temp = (int)input.Peek();
                input.Pop();

                while(StackTemp.Count != 0 && (int)StackTemp.Peek() > temp)
                {
                    input.Push(StackTemp.Peek());
                    StackTemp.Pop();
                }

                if (temp < 10)
                    StackTemp.Push(temp);
            }

            return StackTemp;
        } 
    }
}
