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

        public void clearButtonText(){
            foreach (var button in this.Controls.OfType<Button>()) //clear all text
            {
                if (button.Text.Equals("4") || button.Text.Equals("5") || button.Text.Equals("6") || button.Text.Equals("7")) {
                    button.Text = null;
                }
            }
        }


        public void InitializeField() {
            //initialize the field to 0;
                
            for (int i = 0; i<10; i++){
                for (int j = 0; j < 10; j++) {

                    field[i, j] = (int)Game.FieldState.empty; //type casts empty to an integer value (0)
                    
                }                   
            }

            Console.WriteLine("Field Initialized Successfully.");
        }

        private void Place(int xcoord,int ycoord, int ship) {

            field[xcoord-1, ycoord-1] = ship;
            placing = false;
            //expand, maybe create a separate method for checking collisions?
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //type-cast the sender object to button to work with it
          //  string fieldName = (string)b.Name;
            int xcoord = Int16.Parse(b.AccessibleDescription);
            int ycoord = Int16.Parse(b.AccessibleName);  // i am sorry
            

            if (placing) {
                if (field[xcoord - 1, ycoord - 1] == (int)Game.FieldState.empty) //checks if field is empty
                { 
                    //add a switch case to check which ship it is to place acccordihly
                    //or maybe create a separate place method for each type of ship???

                    Place(xcoord, ycoord, selectedShip);
                    b.Text = selectedShip.ToString();
                    Console.WriteLine("placed a " + selectedShip + " at " + xcoord + " " + ycoord); //debug
                }
                else { MessageBox.Show("A ship is already there!", "Ship present"); }
            }


        }

        private void resetShips_Click(object sender, EventArgs e)
        {
            InitializeField();
            clearButtonText();
        }

        private void placeButtons_Click(object sender, EventArgs e)
        {
            placing = true;
            Button b = (Button)sender; //type-cast the sender object to button to work with it

            string shipSelected = (string)b.Name;

            switch (shipSelected) {
                case "placeBattleship":
                    if (battleShipCount < 1)
                    {
                        Console.WriteLine("Can't place this ship anymore!");
                        placing = false;
                        selectedShip = (int)Game.FieldState.empty;
                    }
                    else
                    {
                        selectedShip = (int)Game.FieldState.battleship;
                        battleShipCount--;
                        
                    }
                    break;
                case "placeCruiser":
                    if (cruiserCount < 1)
                    {
                        Console.WriteLine("Can't place this ship anymore!");
                        placing = false;
                        selectedShip = (int)Game.FieldState.empty;
                    }
                    else
                    {
                        selectedShip = (int)Game.FieldState.cruiser;
                        cruiserCount--;
                    }
                    break;

                case "placeDestroyer":
                    if (destroyerCount < 1)
                    {
                        Console.WriteLine("Can't place this ship anymore!");
                        placing = false;
                        selectedShip = (int)Game.FieldState.empty;
                    }
                    else
                    {
                        selectedShip = (int)Game.FieldState.destroyer;
                        destroyerCount--;
                    }

                    break;
                case "placeSubmarine":
                    if (torpedoBoatCount < 1)
                    {
                        Console.WriteLine("Can't place this ship anymore!");
                        placing = false;
                        selectedShip = (int)Game.FieldState.empty;
                    }
                    else
                    {
                        selectedShip = (int)Game.FieldState.submarine;
                        torpedoBoatCount--;
                    }

                    break;               
            }
        }
    }
}
