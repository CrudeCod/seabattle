using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seabattle
{
    public partial class Form1 : Form
    {
        int a = (int)Game.FieldState.hit; //testing
        public Form1()
        {
            InitializeComponent();
        }

        private void mainMenuStart_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Hide();
        }

        private void mainMenuLabel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            if (Game.ver == "1.0") {
                Console.WriteLine("Success!"); //testing
            }
          
        }
    }
}
