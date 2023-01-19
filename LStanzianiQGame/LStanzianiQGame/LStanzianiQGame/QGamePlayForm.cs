using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LStanzianiQGame;

/* QGamePlayForm.cs
 * QGame Assignment 3
 * Revision History
 * Liam Stanziani, 2022.11.16: Created
 * Liam Stanziani, 2022.11.22: Added Code
 * Liam Stanziani, 2022.11.28: Debugging complete
 * Liam Stanziani, 2022.11.28: Comments added
*/

namespace LStanzianiQGame
{
    public partial class QGamePlayForm : Form
    {
        /// <summary>
        /// Variable initilization
        /// </summary>
        //public List<PictureBox> pictureBoxList;
        public PictureBox[,] pictureBoxesArray;
        public int totalRows;
        public int totalColumns;
        public int totalPbs;
        public int typeTracker;
        public int boxCounter;
        public int moveCounter;
        public PictureBox currentClick;
        public Button currentButton;
        public int moveChanger;

        public QGamePlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A method that handles a click event handler for the load box under the file menu, this will 
        /// allow the user to load their designed level from their computer that will be playable by the
        /// user
        /// </summary>
        /// <param name="sender">An object named sender that the user clicks on</param>
        /// <param name="e">The variable for the EventArgs class</param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    string fileName = dlgOpen.FileName;
                    Console.WriteLine(fileName);
                    load(fileName);

                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// A method that reads the file with the total number of rows, total number of columns,
        /// then the current row, column and type and outputs the correct level design to the screen that
        /// will be able to be played by the user
        /// </summary>
        /// <param name="fileName">The name of the file</param>
        private void load(string fileName)
        {
            Reset();
            StreamReader reader = new StreamReader(fileName);
            totalRows = Convert.ToInt32(reader.ReadLine());
            totalColumns = Convert.ToInt32(reader.ReadLine());
            totalPbs = totalRows * totalColumns;
            Size sizeOfBoxes = new Size(70, 60);
            pictureBoxesArray = new PictureBox[totalRows, totalColumns];
            for (int x = 0; x < totalRows; x++)
            {
                int currentX = 22 + x * sizeOfBoxes.Width;
                for (int y = 0; y < totalColumns; y++)
                {
                    int currentY = 26 + y * sizeOfBoxes.Height;
                    PictureBox pictureBoxes = new PictureBox
                    {
                        Name = "pictureBox" + (x + y),
                        Size = sizeOfBoxes,
                        Location = new Point(currentX, currentY),
                        BorderStyle = BorderStyle.None,
                        Visible = true
                    };

                    for (int i = 0; i < 3; i++)
                    {
                        typeTracker++;

                        if (typeTracker != 3)
                        {
                            reader.ReadLine();
                        }
                        if (typeTracker == 3)
                        {
                            typeTracker = 0;
                            switch (Convert.ToInt32(reader.ReadLine()))
                            {
                                case 0:
                                    pictureBoxes.Image = null;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                                case 1:
                                    pictureBoxes.Image = QGameDesignForm.wall;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                                case 2:
                                    pictureBoxes.Image = QGameDesignForm.redDoor;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                                case 3:
                                    pictureBoxes.Image = QGameDesignForm.greenDoor;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                                case 4:
                                    pictureBoxes.Image = QGameDesignForm.redBox;
                                    boxCounter++;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                                case 5:
                                    pictureBoxes.Image = QGameDesignForm.greenBox;
                                    boxCounter++;
                                    pictureBoxes.Click += pbGrid_Click;
                                    pictureBoxesArray[x, y] = pictureBoxes;
                                    this.Controls.Add(pictureBoxes);
                                    break;
                            }
                        }
                    }
                }
            }
            tbNumberOfRemainingBoxes.Text = Convert.ToString(boxCounter);
            pnlPlayArea.SendToBack();
            reader.Close();
        }

        /// <summary>
        /// A method that handles a click event handler for the pictureboxes, this will allow
        /// the user to click the green and red boxes, which will allow the user to move them around
        /// the level, if they click on a picture box that is not a box, then the buttons will
        /// be disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbGrid_Click(object sender, EventArgs e)
        {
            currentClick = sender as PictureBox;
            if (currentClick.Image == QGameDesignForm.greenBox || currentClick.Image == QGameDesignForm.redBox)
            {
                EnableControls();
            }
            else
            {
                DisableControls();
            }
        }

        /// <summary>
        /// A method that will be run when the user uses the controls, it will move the currently
        /// selected box and will check for collision with other images in other picture boxes found
        /// inside of the copy of the grid with the 2d array, it will also check to see the current 
        /// progress into the game by calling a method that will check to see if there are any more 
        /// boxes left
        /// </summary>
        private void ControlsAndGameTracker(object sender, EventArgs e)
        {
            currentButton = sender as Button;
            switch (currentButton.Text)
            {
                case "Up":
                    for (int x = 0; x < totalRows; x++)
                    {
                        for (int y = totalColumns - 1; y > 0; y--)
                        {
                            try
                            {
                                if (pictureBoxesArray[x, y].Location == currentClick.Location)
                                {
                                    if (pictureBoxesArray[x, y - 1].Image == null)
                                    {
                                        pictureBoxesArray[x, y - 1].Image = currentClick.Image;
                                        currentClick = pictureBoxesArray[x, y - 1];
                                        pictureBoxesArray[x, y].Image = null;
                                    }
									else if (pictureBoxesArray[x, y + 1].Image == QGameDesignForm.wall || pictureBoxesArray[x, y + 1].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.greenBox || pictureBoxesArray[x, y + 1].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.redBox)
									{
										moveCounter++;
										tbNumberOfMoves.Text = moveCounter.ToString();
									}
									else if (pictureBoxesArray[x, y - 1].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.redBox || pictureBoxesArray[x, y - 1].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.greenBox)
                                    {
                                        moveCounter++;
                                        tbNumberOfMoves.Text = moveCounter.ToString();
                                        pictureBoxesArray[x, y].Image = null;
                                        DisableControls();
                                        boxCounter--;
                                        tbNumberOfRemainingBoxes.Text = boxCounter.ToString();
                                        GameLogic();
                                        return;
                                    }
                                }
                            }
                            catch(IndexOutOfRangeException) 
                            {
                                return;
                            }
                        }
                    }
                    break;
                case "Down":
                    for (int x = 0; x < totalRows; x++)
                    {
                        for (int y = 0; y < totalColumns; y++)
                        {
                            try
                            {
                                if (pictureBoxesArray[x, y].Location == currentClick.Location)
                                {
                                    if (pictureBoxesArray[x, y + 1].Image == null)
                                    {
                                        pictureBoxesArray[x, y + 1].Image = currentClick.Image;
                                        currentClick = pictureBoxesArray[x, y + 1];
                                        pictureBoxesArray[x, y].Image = null;
                                    }
                                    else if (pictureBoxesArray[x, y + 1].Image == QGameDesignForm.wall || pictureBoxesArray[x, y + 1].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.greenBox || pictureBoxesArray[x, y + 1].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.redBox)
                                    {
										moveCounter++;
										tbNumberOfMoves.Text = moveCounter.ToString();
									}
                                    else if (pictureBoxesArray[x, y + 1].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.redBox || pictureBoxesArray[x, y + 1].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.greenBox)
                                    {
                                        moveCounter++;
                                        tbNumberOfMoves.Text = moveCounter.ToString();
                                        pictureBoxesArray[x, y].Image = null;
                                        DisableControls();
                                        boxCounter--;
                                        tbNumberOfRemainingBoxes.Text = boxCounter.ToString();
                                        GameLogic();
                                        return;
                                    }
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                return;
                            }
                        }
                    }
                    break;
                case "Left":
                    for (int x = totalRows - 1; x > 0; x--)
                    {
                        for (int y = 0; y < totalColumns; y++)
                        {
                            try
                            {
                                if (pictureBoxesArray[x, y].Location == currentClick.Location)
                                {
                                    if (pictureBoxesArray[x - 1, y].Image == null)
                                    {
                                        pictureBoxesArray[x - 1, y].Image = currentClick.Image;
                                        currentClick = pictureBoxesArray[x - 1, y];
                                        pictureBoxesArray[x, y].Image = null;
                                    }
									else if (pictureBoxesArray[x - 1, y].Image == QGameDesignForm.wall || pictureBoxesArray[x - 1, y].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.greenBox || pictureBoxesArray[x - 1, y].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.redBox)
									{
										moveCounter++;
										tbNumberOfMoves.Text = moveCounter.ToString();
									}
									else if (pictureBoxesArray[x - 1, y].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.redBox || pictureBoxesArray[x - 1, y].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.greenBox)
                                    {
                                        moveCounter++;
                                        tbNumberOfMoves.Text = moveCounter.ToString();
                                        pictureBoxesArray[x, y].Image = null;
                                        DisableControls();
                                        boxCounter--;
                                        tbNumberOfRemainingBoxes.Text = boxCounter.ToString();
                                        GameLogic();
                                        return;
                                    }
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                return;
                            }
                        }
                    }
                    break;
                case "Right":
                    for (int x = 0; x < totalRows; x++)
                    {
                        for (int y = 0; y < totalColumns; y++)
                        {
                            try
                            {
                                if (pictureBoxesArray[x, y].Location == currentClick.Location)
                                {
                                    if (pictureBoxesArray[x + 1, y].Image == null)
                                    {
                                        pictureBoxesArray[x + 1, y].Image = currentClick.Image;
                                        currentClick = pictureBoxesArray[x + 1, y];
                                        pictureBoxesArray[x, y].Image = null;
                                    }
									else if (pictureBoxesArray[x + 1, y].Image == QGameDesignForm.wall || pictureBoxesArray[x + 1, y].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.greenBox || pictureBoxesArray[x + 1, y].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.redBox)
									{
										moveCounter++;
										tbNumberOfMoves.Text = moveCounter.ToString();
									}
									else if (pictureBoxesArray[x + 1, y].Image == QGameDesignForm.redDoor && currentClick.Image == QGameDesignForm.redBox || pictureBoxesArray[x + 1, y].Image == QGameDesignForm.greenDoor && currentClick.Image == QGameDesignForm.greenBox)
                                    {
                                        moveCounter++;
                                        tbNumberOfMoves.Text = moveCounter.ToString();
                                        pictureBoxesArray[x, y].Image = null;
                                        DisableControls();
                                        boxCounter--;
                                        tbNumberOfRemainingBoxes.Text = boxCounter.ToString();
                                        GameLogic();
                                        return;
                                    }
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                return;
                            }
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// A method that checks to see if the boxes moved are at the correct doors, which it then
        /// will delete the doors and boxes and will update the number of boxes left text box,
        /// if the boxes are at 0 the game will end
        /// </summary>
        private void GameLogic()
        {
            if (boxCounter == 0)
            {
                MessageBox.Show("Congrats! You have won!", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Reset();
                return;
            }
        }

        /// <summary>
        /// A method that enables the controls for moving the boxes
        /// </summary>
        private void EnableControls()
        {
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }

        /// <summary>
        /// A method that disables the controls for moving the boxes
        /// </summary>
        private void DisableControls()
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
        }

        /// <summary>
        /// A method that resets the variables for the play form
        /// </summary>
        private void Reset()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            PictureBox[,] pictureBoxesArray;
            typeTracker = 0;
            moveCounter = 0; 
            boxCounter = 0;
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