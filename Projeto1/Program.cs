using System;



namespace Projeto1
{
    
    class Program
    {


        public static class Globals
        {
            
            public static bool[] lamps={false,false,false};
            public static int f=0;
        }
       

        static void Main(string[] args)
        {
            bool[] AllLamps={true,true,true};
           
            Instructions();
            Console.WriteLine($"Initial state:");
            LampState();

            while (Globals.f<6)  
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

                if (Array.TrueForAll(Globals.lamps, item=>item.Equals(true)))
                {
                    Globals.f=0;
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine($"\n \t \t You won!");
                    break;
                }

                
            }

            if (Globals.f==6)
            {
               Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"\n \t \t GAME OVER!"); 
            }

            Console.ResetColor();
        }

        static void ChangeLamp(int a)
        {
            Globals.f++;
            Console.WriteLine($"Buttons were pressed {Globals.f} times:\n");

            if (a != 1)
            {
                Globals.lamps[a-1]= !Globals.lamps[a-1];
                Globals.lamps[a-2]= !Globals.lamps[a-2];
            }
            else 
            {
                Globals.lamps[0]=!Globals.lamps[0];
            }
            
            
            LampState();
        }

        static void LampState()
        {

            foreach (bool item in Globals.lamps)
            {
                if (item==true)
                {
                    Console.Write($"\t \u25CF");
                }
                else if (item==false)
                {
                    Console.Write($"\t \u25CB");
                }
            }
            Console.WriteLine($"\n");
            foreach (bool item in Globals.lamps)
            {
                if (item==true)
                {
                    Console.Write($"\t on");
                }
                else if (item==false)
                {
                    Console.Write($"\t off");
                }
            }
            
            Console.WriteLine($"\n");
        }

        static void Instructions()
        {
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.WriteLine($"\nINSTRUCTIONS:\n");
            Console.WriteLine($"This game has 3 lamps and 3 buttons.");
            Console.WriteLine($"When the lamp is turned off: \u25CB");
            Console.WriteLine($"When the lamp is turned on:  \u25CF \n");
            Console.Write($"To press the buttons 1,2 and 3 the player ");
            Console.WriteLine($"must press the keys 1,2 and 3, respectively");
            Console.WriteLine($"The button 1 switches the state of the lamp 1");
            Console.WriteLine($"The button 2 of the lamps 1 and 2");
            Console.WriteLine($"And the button 3 of the lamps 2 and 3\n");
            Console.Write($"To win the game the player must turn on all ");
            Console.Write($"the lamps without pressing the buttons more ");
            Console.WriteLine($"than 6 times \n");
            
        }
        
         
       
       
    }
}


