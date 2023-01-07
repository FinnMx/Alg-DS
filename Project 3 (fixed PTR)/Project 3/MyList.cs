using System;
using System.Collections.Generic;
using System.Text;

namespace Project_3
{
    class MyList
    {
        const int max = 8;
        int start = 0;
        int av;
        public String[] data = new string[max];
        public int[] weightData = new int[max];
        public int[] link = new int[max];
        public int[] pool = new int[max];

        public String GetName(int val)
        {
           if(data[val] == null)
            {
                return null;
            }
            return data[val];
        }

        public int GetCost(int val)
        {
            return weightData[val];
        }

        public MyList()
        {
            start = 0;
            av = 0;
            for (int i = 0; i < max; i++)
            {
                pool[i] = i;
            }
            pool[max - 1] = -1;
        }

        //initilization of the list...
        public void initilization(int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                pool[i] = i;
            }
            pool[n - 1] = 0;
            av = 1;
        }

        public void getNode(out int reference)
        {
            reference = 0;

            if (av == -1)
            {
                Console.WriteLine("ERROR, LIST HAS REACHED LIMIT");
            }
            else
            {
                reference = av;
                av = pool[av];
                start++;
            }
        }

        public void retNode(int reference)
        {
            pool[reference] = av;
            av = reference;
        }

        public void ins_beg(string item, int item2)
        {
            int ptr = 0;

            getNode(out ptr);
            data[ptr] = item;
            weightData[ptr] = item2;
            link[ptr] = start;
            av++;
        }

        public void ins_end(string item, int item2)
        {
            int ptr;

            if (start == 0)
            {
                ins_beg(item, item2);
            }
            else
            {
 
                getNode(out ptr);
                data[ptr] = item;
                weightData[ptr] = item2;
                link[ptr] = start;
                av++;

            }

        }

        /* NOT NEEDED
        public void ins_at(ref int start, int position, string item, int item2)
        {
            int count = 1;
            int ptr;
            int previous;

            ptr = start;
            previous = start;

            if ((position < 1) || (position > length()))
            {
                Console.WriteLine("INVALID ENTRY ERROR");
            }
            else
            {
                while (count != position && ptr != 0)
                {
                    count = count + 1;
                    previous = ptr;
                    ptr = link[ptr];
                }
                if (position == 0)
                {
                    ins_beg(item, item2);
                }
                else
                {
                    getNode(out ptr);
                    data[ptr] = item;
                    weightData[ptr] = item2;
                    link[ptr] = link[previous];
                    link[previous] = ptr;
                }
            }
        }
        */

        public void display()
        {
            int ptr;
            ptr = start;
            Console.WriteLine("START");
            while (ptr != -1)
            {
                Console.WriteLine("(" + data[ptr] + "," + weightData[ptr] + ")");
                ptr = link[ptr];
            }
            Console.WriteLine("END ");
            Console.WriteLine();
        }

        public int length()
        {
            int ptr = 0;
            int count = 0;

            while (link[ptr] != 0)
            {
                count = count + 1;
                ptr = link[ptr];
            }

            return count;
        }
    }
}
