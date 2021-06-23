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

        int[,] field = new int[10, 10];

        public MainForm()
        {
            InitializeComponent();
            InitializeVariable();
            InitializeField();
        }
        public void InitializeVariable() { // initialize all variables
            battleShipCount = 4; 
            cruiserCount = 6;
            destroyerCount = 6;
            torpedoBoatCount = 4; 


        }
        public void InitializeField() {
            //initialize the field to 0;
            for(int i = 0; i<10; i++){
                for (int j = 0; j < 10; j++) {

                    field[i, j] = (int)Game.FieldState.empty; //type casts empty to an integer value (0)
                    
                }                   
            }

            Console.WriteLine("Field Initialized Successfully.");
        }


        private void button_Click(object sender, EventArgs e)
        {
            sender = (Button)sender; //type-cast the sender object to button to work with it

        }
    }
}
