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
                ConsoleKeyInfo keys=Console.ReadKey(true);
            
                if (keys.Key==ConsoleKey.D1)
                {
                    ChangeLamp(1);
                }
                else if (keys.Key==ConsoleKey.D2)
                {
                    ChangeLamp(2);
                }
                else if (keys.Key==ConsoleKey.D3)
                {
                    ChangeLamp(3);
                }

                
            }
        }


        static void ChangeLamp(int a)
        {

            if (a != 1)
            {
                Globals.lamps[a-1]= !Globals.lamps[a-1];
                Globals.lamps[a-2]= !Globals.lamps[a-2];
            }
            else 
            {
                Globals.lamps[0]=!Globals.lamps[0];
            }
            
            Globals.i++;
            Text();
        }

        static void Text()
        {
            foreach (bool item in Globals.lamps)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"");
        }
       
       
    }
}
