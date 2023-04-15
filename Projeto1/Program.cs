using System;

namespace Projeto1
{
    
    class Program
    {

        //global variables

        public static class Globals
        {
            
            public static bool[] lamps={false,false,false};
            public static int f=0;
        }
       
        //main 
        static void Main(string[] args)
        {
        
            //initial text

            Instructions();
            Console.WriteLine($"Initial state:");
            LampState();

            //main loop
            while (Globals.f<6)  
            {   
                
                //Keys for the buttons
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

                //Player wins
                if (Array.TrueForAll(Globals.lamps, item=>item.Equals(true)))
                {
                    
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine($"\n \t \t You won!");
                    Console.Write($"\t \t You pressed the buttons {Globals.f}");
                    Console.WriteLine($" times");
                    Globals.f=0;
                    break;
                }

                
            }

            //Player loses
            if (Globals.f==6)
            {
               Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"\n \t \t GAME OVER!"); 
            }

            Console.ResetColor();
        }

        //changes the states of the lamps depending on a
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

        //Show the state of the lamps
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

        //text in the beginning to explain to the player how to play
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


