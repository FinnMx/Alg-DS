using System;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList[] NYPossibilities = new MyList[7];
            MyList NY1 = new MyList();
            NY1.ins_beg("Miami", 90);
            NY1.ins_end("Dallas", 50);
            NY1.ins_end("San Diego", 90);
            NY1.ins_end("LA", 45);
            MyList NY2 = new MyList();
            NY2.ins_beg("Dallas", 90);
            NY2.ins_beg("San Diego", 90);
            NY2.ins_beg("LA", 45);
            MyList NY3 = new MyList();
            NY3.ins_beg("Dallas", 90);
            NY3.ins_beg("LA", 80);
            MyList NY4 = new MyList();
            NY4.ins_beg("Denver", 100);
            NY4.ins_beg("LA", 100);
            MyList NY5 = new MyList();
            NY5.ins_beg("Denver", 100);
            NY5.ins_beg("San Francisco", 75);
            NY5.ins_beg("LA", 45);
            MyList NY6 = new MyList();
            NY6.ins_beg("Chicago", 75);
            NY6.ins_beg("Denver", 20);
            NY6.ins_beg("LA", 100);
            MyList NY7 = new MyList();
            NY7.ins_beg("Chicago", 75);
            NY7.ins_beg("San Francisco", 25);
            NY7.ins_beg("LA", 45);
            NYPossibilities[0] = NY1;
            NYPossibilities[1] = NY2;
            NYPossibilities[2] = NY3;
            NYPossibilities[3] = NY4;
            NYPossibilities[4] = NY5;
            NYPossibilities[5] = NY6;
            NYPossibilities[6] = NY7;

            MyList[] MIPossibilities = new MyList[2];
            MyList MI1 = new MyList();
            MI1.ins_beg("Dallas", 50);
            MI1.ins_end("San Diego", 90);
            MI1.ins_end("LA", 45);
            MyList MI2 = new MyList();
            MI1.ins_beg("Dallas", 50);
            MI1.ins_end("LA", 80);
            MIPossibilities[0] = MI1;
            MIPossibilities[1] = MI2;

            MyList[] DAPossibilities = new MyList[2];
            MyList DA1 = new MyList();
            DA1.ins_beg("San Diego", 90);
            DA1.ins_end("LA", 45);
            MyList DA2 = new MyList();
            DA2.ins_beg("LA", 80);
            DAPossibilities[0] = DA1;
            DAPossibilities[1] = DA2;

            MyList[] CHPossibilities = new MyList[3];
            MyList CH1 = new MyList();
            CH1.ins_beg("Denver", 20);
            CH1.ins_end("LA", 100);
            MyList CH2 = new MyList();
            CH2.ins_beg("Denver", 20);
            CH2.ins_end("San Francisco", 75);
            CH2.ins_end("LA", 45);
            MyList CH3 = new MyList();
            CH3.ins_beg("San Francisco", 25);
            CH3.ins_end("LA", 45);
            CHPossibilities[0] = CH1;
            CHPossibilities[1] = CH2;
            CHPossibilities[2] = CH3;
            

            MyList[] DEPossibilities = new MyList[2];
            MyList DE1 = new MyList();
            DE1.ins_beg("LA", 100);
            MyList DE2 = new MyList();
            DE2.ins_beg("San Francisco", 75);
            DE2.ins_beg("LA", 45);
            DEPossibilities[0] = DE1;
            DEPossibilities[1] = DE2;

            MyList[] SDPossibilities = new MyList[1];
            MyList SD1 = new MyList();
            SD1.ins_beg("LA", 45);
            SDPossibilities[0] = SD1;

            MyList[] SFPossibilities = new MyList[1];
            MyList SF1 = new MyList();
            SF1.ins_beg("LA", 45);
            SFPossibilities[0] = SF1;

            int op;
            string op2;
            Console.WriteLine("Please enter the city you want to ship from:\n1)New York\n2)Chicago\n3)San Francisco\n4)Denver\n5)Dallas\n6)Miami\n7)San Diego\n8)LA");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the city you want to ship to");
            op2 = Console.ReadLine();

            switch (op)
            {
                case 1:
                    findRoutes(NYPossibilities, op2);
                    break;
                case 2:
                    findRoutes(CHPossibilities, op2);
                    break;
                case 3:
                    findRoutes(SFPossibilities, op2);
                    break;
                case 4:
                    findRoutes(DEPossibilities, op2);
                    break;
                case 5:
                    findRoutes(DAPossibilities, op2);
                    break;
                case 6:
                    findRoutes(MIPossibilities, op2);
                    break;
                case 7:
                    findRoutes(SDPossibilities, op2);
                    break;
                case 8:
                    Console.WriteLine("CANNOT SHIP FROM LA, NO PATHS PRESENT");
                    break;
                default:
                    Console.WriteLine("INVALID ENTRY");
                    Console.ReadKey();
                    break;
            }
            void findRoutes(MyList[] x, String dest)
            {

                foreach (MyList n in x)
                {
                    int Totalcost = 0;
                    String TotalJourny = "";

                    for (int i = 0; i <= n.length(); i++)
                    {
                        Totalcost += n.GetCost(i);
                        TotalJourny = TotalJourny + n.GetName(i) + " -> ";

                        if(dest == n.GetName(i))
                        {
                            Console.WriteLine(TotalJourny + "END" + "\n" + "£" + Totalcost);
                            break;
                        }
                    }
                }
            }
        }


    }
}

