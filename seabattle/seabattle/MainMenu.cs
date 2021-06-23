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
    public partial class MainMenu : Form
    {
        int a = (int)Game.FieldState.hit; //testing
        public MainMenu()
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Mikael Khudiev and Savva Krasnokutskiy " +
           "as a small scale project to hone our skills in C#. In this classic game " +
           ", you have to sink the opponents ships, playing either against AI" +
           " or a real player on the network.", "About");
        }
    }
}
