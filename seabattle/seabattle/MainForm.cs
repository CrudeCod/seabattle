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
    public partial class MainForm : Form
    {
        bool turn = true; //true means player 1 turn, false means player 2 turn.
         //counters for ships
        private byte battleShipCount;
        private byte cruiserCount;
        private byte destroyerCount;
        private byte torpedoBoatCount;
        public MainForm()
        {
            InitializeComponent();
            InitializeVariable();
        }
        public void InitializeVariable() { // initialize all variables
            battleShipCount = 4; 
            cruiserCount = 6;
            destroyerCount = 6;
            torpedoBoatCount = 4; 
        }
        private void button_Click(object sender, EventArgs e)
        {

        }
    }
}
