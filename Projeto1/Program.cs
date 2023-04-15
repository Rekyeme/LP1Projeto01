using System;
using System.Windows.Forms

namespace Projeto1
{
    class Interactive Objects 
    {
        private void create_buttons (object sender, EventArgs e)
        
            //Creates the 1st button that changes the state of the 1st lamp;
            //Example: If the lamp is On, switch its state to Off and vice versa;
            button1 = new Button;
            button1.Location = new System.Drawing.Point(15, 15);
            button1.Size = new.System.Drawing.Size(90, 30);
            button1.Label = "Lamp 1";
            button1.Press += System.EventHandler(button1.Press);
            this.Controls.Add(button1);

            //Creates the 2nd button that changes the state of the 1st and 2nd lamp;
            //Example: If the 1st lamp is On and the 2nd is Off, switch their states to Off and On;
            button2 = new Button();
            button2.Location = new System.Drawing.Point(125, 15);
            button2.Size = new.System.Drawing.Size(90,30);
            button2.Label = "Lamp 1 and Lamp 2";
            button2.Press += System.EventHandler(button2.Press);
            this.Controls.Add(button2)

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

            //Creates the 2nd lamp;
            lamp2 = new Lamp();
            lamp2.Location = new System.Drawing.Point(140, 60); 
            lamp2.Size = new System.Drawing.Size(140, 60);
            lamp2.Label = "Lamp 2";
            this.Controls.Add(lamp2)

            //Creates the 3rd lamp;
            lamp3 = new Lamp();
            lamp3.Location = new System.Drawing.Point(250, 60); 
            lamp3.Size = new System.Drawing.Size(140, 60);
            lamp3.Label = "Lamp 1";
            this.Controls.Add(lamp3)
    }   

}

