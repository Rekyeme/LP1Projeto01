# LP1Projeto01 - Puzzle das Lâmpadas


## Autoria:

Samuel Carvalho (a22201379): Criou o repositório e fez o commit inicial. Após isso começou a escrever o código, que foi finalizado pela colega de grupo. 
Por fim escreveu o relatório em Markdown.  

Vitoria Rodrigues (a22204356): Criou a pasta do projeto após o commit inicial. Corrigiu e finalizou o código previamente escrito.


## Arquitetura do Projeto

Inicialmente, começou por definir-se cada objeto individualmente, por exemplo:

            //Creates the 3rd button that changes the state of the 2nd and 3rd lamp;
            //Example: If the 2nd lamp is On and the 3rd is Off, switch their states to Off and On;
            button3 = new Button();
            button3.Location = new System.Drawing.Point(225, 15);
            button3.Size = new.System.Drawing.Size(90,30);
            button3.Label = "Lamp 2 and Lamp 3";
            button3.Press += System.EventHandler(button3.Press);
            this.Controls.Add(button3)

            //Creates the 1st lamp
            lamp1 = new Lamp();
            lamp1.Location = new System.Drawing.Point(30, 60); 
            lamp1.Size = new System.Drawing.Size(140, 60);
            lamp1.Label = "Lamp 1";
            this.Controls.Add(lamp1)
            
Dado o facto que esta abordagem era totalmente ineficiente, acabou por ser totalmente corrigida nos commits que se seguiram.


Começou-se então por criar e definir uma classe 'Globals'. Dentro dessa classe foram criadas duas variáveis: um array de booleanos definido como 'lamps' representando o estado das três lâmpadas e uma variável de inteiros denominada 'f' representando o número de vezes que o jogador pressiona os botões.

            public static class Globals
            {

                public static bool[] lamps={false,false,false};
                public static int f=0;
            }
        
        
De seguida foi adicionado um método 'main'. Este método dá início ao loop do jogo, onde começa por mostrar as instruções do jogo e o estado inicial das lâmpadas.
Após isso, este método lê as teclas pressionadas pelo jogador e chama o método 'ChangeLamp'. 
Por fim, se o jogador ganhar, aparece uma mensagem com o número de movimentos efetuados pelo mesmo e faz reset ao contador de teclas pressionadas, caso contrário aparece uma mensagem a dizer que o jogo acabou.
             
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
        
      
O próximo método, 'ChangeLamp', está encarregue de incrementar o contador de movimentos, trocar os estados das lâmpadas e mostrar o novo estado em que as mesmas se encontram. 

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
                
                
O método seguinte mostra o estado das lâmpadas como círculos juntamente com as palavras 'On' e 'Off'.

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


Por fim, este último método é o responsável por definir e mostrar as regras do jogo.

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
        
        
## Fluxograma
![Diagrama_Projeto01LP1](https://user-images.githubusercontent.com/115167862/232330353-77d7f451-f1ce-4a34-a52d-0b18047a7946.png)


## Referências
As primeiras partes de código escritas que foram posteriormente apagadas totalmente foram criadas com a ajuda do Chat GPT e do Google.
De resto, não foi usada nenhuma referência para a realização do projeto.


