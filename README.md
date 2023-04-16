# LP1Projeto01 - Puzzle das Lâmpadas

## Autoria:

Samuel Carvalho (a22201379): Criou o repositório e fez o commit inicial. Após isso começou a escrever o código, que foi finalizado pela colega de grupo. 
Por fim escreveu o relatório em Markdown.  

Vitoria Rodrigues (a22204356): Criou a pasta do projeto após o commit inicial. Corrigiu e finalizou o código previamente escrito.

## Arquitetura do Projeto

Inicialmente, começou por definir-se cada objeto individualmente, por exemplo:

            //Creates the 2nd button that changes the state of the 1st and 2nd lamp;
            //Example: If the 1st lamp is On and the 2nd is Off, switch their states to Off and On;
            button2 = new Button();
            button2.Location = new System.Drawing.Point(125, 15);
            button2.Size = new.System.Drawing.Size(90,30);
            button2.Label = "Lamp 1 and Lamp 2";
            button2.Press += System.EventHandler(button2.Press);
            this.Controls.Add(button2)

            //Creates the 1st lamp
            lamp1 = new Lamp();
            lamp1.Location = new System.Drawing.Point(30, 60); 
            lamp1.Size = new System.Drawing.Size(140, 60);
            lamp1.Label = "Lamp 1";
            this.Controls.Add(lamp1)
            
Dado o facto que esta abordagem era bastante ineficiente, acabou por ser totalmente corrigida nos commits que se seguiram.

Começou-se então por criar e defenir uma classe 'Globals'. Dentro dessa classe foram criadas duas variáveis: um array de boleanos definido como 'lamps' representando o estado das três lampadas e uma variável de inteiros denominada 'f' representando o numero de vezes que o jogador pressionou os botões.

        public static class Globals
        {
            
            public static bool[] lamps={false,false,false};
            public static int f=0;
        }
