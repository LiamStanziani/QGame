using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

/* QGameDesignForm.cs
 * QGame Assignment 3
 * Revision History
 * Liam Stanziani, 2022.10.23: Created
 * Liam Stanziani, 2022.11.03: Added Code
 * Liam Stanziani, 2022.11.04: Debugging complete
 * Liam Stanziani, 2022.10.04: Comments added
*/

namespace LStanzianiQGame
{
    /// <summary>
    /// A class that controls the QGameDesignForm which allows the user to create rows, columns for a level and add
    /// items to that level that can be saved to the computer and can be played, which they can't play them till
    /// assignment 3
    /// </summary>
    public partial class QGameDesignForm : Form
    {
        /// <summary>
        /// Variable initilization
        /// </summary>
        public Regex isNumber = new Regex("^[0-9]+$");
        public Button btnOptions;
        public PictureBox pbOptions;
        public static Image wall = LStanzianiQGame.Properties.Resources.Wall;
        public static Image redDoor = LStanzianiQGame.Properties.Resources.red_door;
        public static Image greenDoor = LStanzianiQGame.Properties.Resources.green_door;
        public static Image redBox = LStanzianiQGame.Properties.Resources.red_box;
        public static Image greenBox = LStanzianiQGame.Properties.Resources.green_box;
        public static Image currentlySelected;
        public int totalRows;
        public int totalColumns;
        public int totalPB;
        public int wallCounter;
        public int doorCounter;
        public int boxCounter;
        public Image previouslySelected;
        public List<PictureBox> pictureBoxGrid = new List<PictureBox>();
        public int[] typeOfImage;
        public List<int> fullOutput = new List<int>();
        public int typeOfImageCounter;
        public int imageCounter;


        /// <summary>
        /// The default constructor of the QGameDesignForm class
        /// </summary>
        public QGameDesignForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A method that handles a click event handler for the generate button, this will check to see how many
        /// rows, and columns of picture boxes need to be made on the form, and will output them to the screen in
        /// the amount that the user inputed in the textboxes for the rows and columns
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (isNumber.IsMatch(tbRows.Text) == true && isNumber.IsMatch(tbColumns.Text) == true)
            {
                int tbRowsInt = Convert.ToInt32(tbRows.Text);
                int tbColumnsInt = Convert.ToInt32(tbColumns.Text);
                totalRows = tbRowsInt;
                totalColumns = tbColumnsInt;
                Size sizeOfBoxes = new Size(70, 60);
                totalPB = totalRows * totalColumns;
                for (int x = 0; x < tbRowsInt; x++)
                {
                    int currentX = 246 + x * sizeOfBoxes.Width;
                    for (int y = 0; y < tbColumnsInt; y++)
                    {
                        int currentY = 172 + y * sizeOfBoxes.Height;
                        PictureBox pictureBoxes = new PictureBox
                        {
                            Name = "pictureBox" + (x + y),
                            Size = sizeOfBoxes,
                            Location = new Point(currentX, currentY),
                            BorderStyle = BorderStyle.Fixed3D,
                            Visible = true
                        };
                        pictureBoxGrid.Add(pictureBoxes);
                        fullOutput.Add(x);
                        fullOutput.Add(y);
                        pictureBoxes.Click += pbGrid_Click;
                        this.Controls.Add(pictureBoxes);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input valid numbers for the rows and columns, " +
                    "they must both be intergers");
                return;
            }
        }

        /// <summary>
        /// A method that handles the click event handlers for all of the buttons found inside of the toolbox, 
        /// this will allows the correct button with the correct picture to be assigned to an image
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void btnToolBox_Click(object sender, EventArgs e)
        {
            btnOptions = sender as Button;
            switch (btnOptions.Text)
            {
                case "None":
                    currentlySelected = null;
                    break;
                case "Wall":
                    currentlySelected = wall;
                    break;
                case "Red Door":
                    currentlySelected = redDoor;
                    break;
                case "Green Door":
                    currentlySelected = greenDoor;
                    break;
                case "Red Box":
                    currentlySelected = redBox;
                    break;
                case "Green Box":
                    currentlySelected = greenBox;
                    break;
            }
        }

        /// <summary>
        /// A method that handles the click event handlers for all of the generated picture boxes, this
        /// will allow users to use the currently selected image from the tool box and place it onto
        /// the picture box level, this also checks if there is a previously selected image, so that the
        /// counters for the message box after saving file will be accurate
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void pbGrid_Click(object sender, EventArgs e)
        {
            pbOptions = sender as PictureBox;
            previouslySelected = pbOptions.BackgroundImage;
            if (previouslySelected == currentlySelected)
            {
                return;
            }
            pbOptions.BackgroundImageLayout = ImageLayout.Zoom;
            pbOptions.BackgroundImage = currentlySelected;
            int pbIndex = pictureBoxGrid.IndexOf(sender as PictureBox);
            pictureBoxGrid[pbIndex].BackgroundImage = pbOptions.BackgroundImage;
        }
        /// <summary>
        /// This method will check the current picture box, then it will find the image inside of the 
        /// picture box, and it will add to the counter and add to the list that will be outputted on 
        /// saving the level
        /// </summary>
        public void CheckForImage()
        { 
            typeOfImage = new int[pictureBoxGrid.Count];
            for (int j = 0; j < pictureBoxGrid.Count; j++)
            {
                if (pictureBoxGrid[j].BackgroundImage == wall)
                {
                    wallCounter++;
                    typeOfImage[j] = 1;
                }
                else if (pictureBoxGrid[j].BackgroundImage == redDoor)
                {
                    doorCounter++;
                    typeOfImage[j] = 2;
                }
                else if (pictureBoxGrid[j].BackgroundImage == greenDoor)
                {
                    doorCounter++;
                    typeOfImage[j] = 3;
                }
                else if (pictureBoxGrid[j].BackgroundImage == redBox)
                {
                    boxCounter++;
                    typeOfImage[j] = 4;
                }
                else if (pictureBoxGrid[j].BackgroundImage == greenBox)
                {
                    boxCounter++;
                    typeOfImage[j] = 5;
                }
                else if (pictureBoxGrid[j].BackgroundImage == null)
                {
                    typeOfImage[j] = 0;
                }
            }
        }

        /// <summary>
        /// A method that handles a click event handler for the save box under the file menu, this will 
        /// allow the user to save their designed level to their computer and a message box
        /// will pop up saying that it was saved successfully of with the amount of items of each type
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        int numberOfItems = totalPB;
                        string fileName = dlgSave.FileName;
                        save(fileName, numberOfItems);
                        MessageBox.Show("File saved successfuly:" + "\n" + "Total number of walls: " + wallCounter
                            + "\n" + "Total number of doors: " + doorCounter + "\n" + "Total Number of Boxes: " + boxCounter);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in saving file: " + ex.Message);
                        throw;
                    }
                    break;
                case DialogResult.Cancel:
                default:
                    break;
            }
        }

        /// <summary>
        /// A method that writes to the file with the total number of rows, total number of columns,
        /// then the current row, column and type
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        private void save(string fileName, int numberOfItems)
        {
            CheckForImage();

            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(totalRows);
            writer.WriteLine(totalColumns);

            for (int i = 0; i < fullOutput.Count; i++)
            {
                writer.WriteLine(fullOutput[i]);
                typeOfImageCounter++;
                if (typeOfImageCounter == 2)
                {
                    writer.WriteLine(typeOfImage[imageCounter]);
                    imageCounter++;
                    typeOfImageCounter = 0;
                }
            }

            writer.Close();
        }

        /// <summary>
        /// A method that handles a click event handler for the close box under the file menu,
        /// this will allow the user to close the design form application
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
