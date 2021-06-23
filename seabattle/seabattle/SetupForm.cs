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
    public partial class SetupForm : Form
    {
         //counters for ships for placing purposes
        private byte battleShipCount;
        private byte cruiserCount;
        private byte destroyerCount;
        private byte torpedoBoatCount;
        private byte selectedShip; //ship that is currently being placed by the player
        private bool placing = false;

        public int[,] field = new int[10, 10];

        public SetupForm()
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

        private void Place(int xcoord,int ycoord, int ship) {
            field[xcoord, ycoord] = ship;
            placing = false;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //type-cast the sender object to button to work with it
          //  string fieldName = (string)b.Name;
            int xcoord = Int16.Parse(b.AccessibleDescription);
            int ycoord = Int16.Parse(b.AccessibleName);  // i am sorry
            

            if (placing) {
                Place(xcoord, ycoord,selectedShip);
                Console.WriteLine("placed a " + selectedShip + " at " + xcoord + " " + ycoord);
            }


        }

        private void resetShips_Click(object sender, EventArgs e)
        {
            InitializeField();
        }

        private void placeButtons_Click(object sender, EventArgs e)
        {
            placing = true;
            Button b = (Button)sender; //type-cast the sender object to button to work with it

            string shipSelected = (string)b.Name;

            switch (shipSelected) {
                case "placeBattleship":
                    selectedShip = (int)Game.FieldState.battleship;
                    break;
                case "placeCruiser":
                    selectedShip = (int)Game.FieldState.cruiser;
                    break;
                case "placeDestroyer":
                    selectedShip = (int)Game.FieldState.destroyer;
                    break;
                case "placeSubmarine":
                    selectedShip = (int)Game.FieldState.submarine;
                    break;               
            }
        }
    }
}
