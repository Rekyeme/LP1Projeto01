using System;

namespace Projeto1
{
    
    class Program
    {
        private void create_buttons (object sender, EventArgs e)
        {
            //Creates the button for the first lamp
              button1 = new Button();
              button1.Location = new System.Drawing.Point(15, 15);
              button1.Size = new.System.Drawing.Size(90, 30);
              button1.Label = "Lamp 1";
              button1.Press += System.EventHandler(button1.Press);
              this.Controls.Add(button1);
        }
    }
}
