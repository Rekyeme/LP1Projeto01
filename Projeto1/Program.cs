using System;

namespace Projeto1
{
   
    class Program
    {


        public static class Globals
        {
            public static int i=0;
            public static bool[] lamps={false,false,false};
        }
       

        static void Main(string[] args)
        {

            while (Globals.i<6)
            {   
                
            
                if (Console.ReadKey(true).Key!=ConsoleKey.NumPad1)
                {
                    ChangeLamp(1);
                }
                if (Console.ReadKey(true).Key!=ConsoleKey.NumPad2)
                {
                    ChangeLamp(2);
                }
                if (Console.ReadKey(true).Key!=ConsoleKey.NumPad3)
                {
                    ChangeLamp(3);
                }

                
            }
        }


        static void ChangeLamp(int a)
        {
            if (a==1)
            {
                Globals.lamps[a-1]= !Globals.lamps[a-1];
                Globals.i++;
            }
            if (a!=1)
            {
                Globals.lamps[a-1]= !Globals.lamps[a-1];
                Globals.lamps[a-2]= !Globals.lamps[a-2];
                Globals.i++;
            }
            Text();
        }

        static void Text()
        {
            foreach (bool item in Globals.lamps)
                {
                    Console.Write($"{item}");
                }
                Console.WriteLine($"");
        }
       
       
    }
}
