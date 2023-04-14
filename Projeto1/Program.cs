using System;
using System.Windows.Forms

namespace Projeto1
{
    class Object
    {
        private void create_buttons (object sender, EventArgs e)
        
            //Creates the first button that changes the state of the first lamp;
            button1 = new Button;
            button1.Location = new System.Drawing.Point(15, 15);
            button1.Size = new.System.Drawing.Size(90, 30);
            button1.Label = "Lamp 1";
            button1.Press += System.EventHandler(button1.Press);
            this.Controls.Add(button1);

            //Creates the second button that changes the state of the first and second lamp;
            button2 = new Button();
            button2.Location = new System.Drawing.Point(125, 15);
            button2.Size = new.System.Drawing.Size(90,30);
            button2.Label = "Lamp 1 and Lamp 2";
            button2.Press += System.EventHandler(button2.Press);
            this.Controls.Add(button2)

            //Creates the third button that changes the state of the second and third lamp;
            button3 = new Button();
            button3.Location = new System.Drawing.Point(225, 15);
            button3.Size = new.System.Drawing.Size(90,30);
            button3.Label = "Lamp 2 and Lamp 3";
            button3.Press += System.EventHandler(button3.Press);
            this.Controls.Add(button3)
    } 
}

