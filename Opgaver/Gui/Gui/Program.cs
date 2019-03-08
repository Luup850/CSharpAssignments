using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new Calculator());
        }
    }

    class Calculator : Form
    {
        private Button Button1;

        public Calculator()
        {
            this.Text = "Hello world";

            Button1 = new Button();

            Button1.Text = "Click me";
            Button1.Click += Button1_Clicked;

            Controls.Add(Button1);
        }

        private void Button1_Clicked(Object sender, EventArgs e)
        {
            Button1.Text = "You clicked!";
            MessageBox.Show("You clicked the button!");
        }
    }
}
