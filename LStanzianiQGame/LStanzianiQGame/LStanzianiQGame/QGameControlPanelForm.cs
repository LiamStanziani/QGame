using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Form1.cs
 * QGame Assignment 3
 * Revision History
 * Liam Stanziani, 2022.10.23: Created
 * Liam Stanziani, 2022.11.02: Added Code
 * Liam Stanziani, 2022.11.02: Debugging complete
 * Liam Stanziani, 2022.11.02: Comments added
*/

namespace LStanzianiQGame
{
    /// <summary>
    /// A class that controls the QGameControlPanelForm which allows the user to choose what they want to do with
    /// the program, they can design the layout of the level,
    /// exit the application, and play an already existing level
    /// </summary>
    public partial class QGameControlPanelForm : Form
    {
        /// <summary>
        /// The default constructor of the QGameControlPanelForm class
        /// </summary>
        public QGameControlPanelForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Variable initilization
        /// </summary>
        private Button btnOptions;

        /// <summary>
        /// A method that handles the click events for the three buttons shown on the control panel form:
        /// the design button, which will open a new application tab and will allow the user to design a
        /// level that can be saved, the play button, and the exit button, which will exit the application
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void btnControlPanelOptions(object sender, EventArgs e)
        {
            btnOptions = sender as Button;
            switch (btnOptions.Text)
            {
                case "Design":
                    QGameDesignForm design = new QGameDesignForm();
                    design.Height = 1300;
                    design.Width = 1000;
                    design.Show();
                    break;
                case "Play":
                    QGamePlayForm play = new QGamePlayForm();
                    play.Height = 1300;
                    play.Width = 1000;
                    play.Show();
                    break;
                case "Exit":
                    Close();
                    break;
            }
        }
    }
}
