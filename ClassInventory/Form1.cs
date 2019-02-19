using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player> playerList = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 

            // TODO - create object with gathered information

            // TODO - add object to global list

            // TODO - display message to indicate addition made

            string name, team, position;
            int age;

            name = nameInput.Text;
            team = teamInput.Text;
            position = positionInput.Text;
            age = Convert.ToInt32(ageInput.Text);


            Player c = new Player(name, team, position, age);
            playerList.Add(c);

            errorOutput.Text = "Player added";
            }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // TODO - if object is in list remove it

            // TODO - display message to indicate deletion made
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO - show all objects in list
        }
    }
}
