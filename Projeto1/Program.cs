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
                if ( Console.ReadKey(true).Key!=ConsoleKey.NumPad1)
                {
                    ChangeLamp(1);
                }

                Console.WriteLine($"{Globals.lamps[0]}");
            }
        }
        static void ChangeLamp(int a)
        {
            Globals.lamps[a-1]= !Globals.lamps[a-1];
            Globals.i++;

        }
       
       
    }
}
