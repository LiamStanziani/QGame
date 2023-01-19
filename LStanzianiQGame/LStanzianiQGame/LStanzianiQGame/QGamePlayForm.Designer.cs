namespace LStanzianiQGame
{
    partial class QGamePlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.tbNumberOfMoves = new System.Windows.Forms.TextBox();
            this.tbNumberOfRemainingBoxes = new System.Windows.Forms.TextBox();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.lblNumberOfRemainingBoxes = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pnlPlayArea = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // tbNumberOfMoves
            // 
            this.tbNumberOfMoves.Location = new System.Drawing.Point(967, 106);
            this.tbNumberOfMoves.Name = "tbNumberOfMoves";
            this.tbNumberOfMoves.ReadOnly = true;
            this.tbNumberOfMoves.Size = new System.Drawing.Size(195, 22);
            this.tbNumberOfMoves.TabIndex = 2;
            this.tbNumberOfMoves.Text = "0";
            this.tbNumberOfMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumberOfRemainingBoxes
            // 
            this.tbNumberOfRemainingBoxes.Location = new System.Drawing.Point(967, 246);
            this.tbNumberOfRemainingBoxes.Name = "tbNumberOfRemainingBoxes";
            this.tbNumberOfRemainingBoxes.ReadOnly = true;
            this.tbNumberOfRemainingBoxes.Size = new System.Drawing.Size(195, 22);
            this.tbNumberOfRemainingBoxes.TabIndex = 3;
            this.tbNumberOfRemainingBoxes.Text = "0";
            this.tbNumberOfRemainingBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.AutoSize = true;
            this.lblNumberOfMoves.Location = new System.Drawing.Point(964, 77);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(116, 16);
            this.lblNumberOfMoves.TabIndex = 4;
            this.lblNumberOfMoves.Text = "Number of Moves:";
            // 
            // lblNumberOfRemainingBoxes
            // 
            this.lblNumberOfRemainingBoxes.AutoSize = true;
            this.lblNumberOfRemainingBoxes.Location = new System.Drawing.Point(964, 208);
            this.lblNumberOfRemainingBoxes.Name = "lblNumberOfRemainingBoxes";
            this.lblNumberOfRemainingBoxes.Size = new System.Drawing.Size(181, 16);
            this.lblNumberOfRemainingBoxes.TabIndex = 5;
            this.lblNumberOfRemainingBoxes.Text = "Number of Remaining Boxes:";
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(1046, 687);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(89, 72);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.ControlsAndGameTracker);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(1046, 765);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(89, 72);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.ControlsAndGameTracker);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(951, 765);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(89, 72);
            this.btnLeft.TabIndex = 6;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.ControlsAndGameTracker);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(1141, 765);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(89, 72);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.ControlsAndGameTracker);
            // 
            // pnlPlayArea
            // 
            this.pnlPlayArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayArea.Location = new System.Drawing.Point(12, 31);
            this.pnlPlayArea.Name = "pnlPlayArea";
            this.pnlPlayArea.Size = new System.Drawing.Size(896, 988);
            this.pnlPlayArea.TabIndex = 7;
            // 
            // QGamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 1055);
            this.Controls.Add(this.pnlPlayArea);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblNumberOfRemainingBoxes);
            this.Controls.Add(this.lblNumberOfMoves);
            this.Controls.Add(this.tbNumberOfRemainingBoxes);
            this.Controls.Add(this.tbNumberOfMoves);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QGamePlayForm";
            this.Text = "QGamePlayForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.TextBox tbNumberOfMoves;
        private System.Windows.Forms.TextBox tbNumberOfRemainingBoxes;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.Label lblNumberOfRemainingBoxes;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel pnlPlayArea;
    }
}