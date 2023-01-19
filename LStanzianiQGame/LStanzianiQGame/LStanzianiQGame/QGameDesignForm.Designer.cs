namespace LStanzianiQGame
{
    partial class QGameDesignForm
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.pnlRowsColumns = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbColumns = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbGreenBox = new System.Windows.Forms.PictureBox();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.pbRedBox = new System.Windows.Forms.PictureBox();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.pbGreenDoor = new System.Windows.Forms.PictureBox();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.pbRedDoor = new System.Windows.Forms.PictureBox();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.pbWall = new System.Windows.Forms.PictureBox();
            this.btnWall = new System.Windows.Forms.Button();
            this.pbNone = new System.Windows.Forms.PictureBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlRowsColumns.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1332, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlRowsColumns
            // 
            this.pnlRowsColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRowsColumns.Controls.Add(this.btnGenerate);
            this.pnlRowsColumns.Controls.Add(this.tbColumns);
            this.pnlRowsColumns.Controls.Add(this.lblColumns);
            this.pnlRowsColumns.Controls.Add(this.tbRows);
            this.pnlRowsColumns.Controls.Add(this.lblRows);
            this.pnlRowsColumns.Location = new System.Drawing.Point(0, 31);
            this.pnlRowsColumns.Name = "pnlRowsColumns";
            this.pnlRowsColumns.Size = new System.Drawing.Size(1332, 80);
            this.pnlRowsColumns.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(391, 16);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 47);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbColumns
            // 
            this.tbColumns.Location = new System.Drawing.Point(245, 28);
            this.tbColumns.Name = "tbColumns";
            this.tbColumns.Size = new System.Drawing.Size(103, 22);
            this.tbColumns.TabIndex = 3;
            this.tbColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(177, 28);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(62, 16);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns:";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(63, 28);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(96, 22);
            this.tbRows.TabIndex = 1;
            this.tbRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 28);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(44, 16);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblToolBox.Location = new System.Drawing.Point(75, 12);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(83, 25);
            this.lblToolBox.TabIndex = 2;
            this.lblToolBox.Text = "Toolbox";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbGreenBox);
            this.panel1.Controls.Add(this.btnGreenBox);
            this.panel1.Controls.Add(this.pbRedBox);
            this.panel1.Controls.Add(this.btnRedBox);
            this.panel1.Controls.Add(this.pbGreenDoor);
            this.panel1.Controls.Add(this.btnGreenDoor);
            this.panel1.Controls.Add(this.pbRedDoor);
            this.panel1.Controls.Add(this.btnRedDoor);
            this.panel1.Controls.Add(this.pbWall);
            this.panel1.Controls.Add(this.btnWall);
            this.panel1.Controls.Add(this.pbNone);
            this.panel1.Controls.Add(this.btnNone);
            this.panel1.Controls.Add(this.lblToolBox);
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 942);
            this.panel1.TabIndex = 3;
            // 
            // pbGreenBox
            // 
            this.pbGreenBox.BackColor = System.Drawing.Color.LightGreen;
            this.pbGreenBox.BackgroundImage = global::LStanzianiQGame.Properties.Resources.green_box;
            this.pbGreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGreenBox.Location = new System.Drawing.Point(34, 439);
            this.pbGreenBox.Name = "pbGreenBox";
            this.pbGreenBox.Size = new System.Drawing.Size(60, 58);
            this.pbGreenBox.TabIndex = 9;
            this.pbGreenBox.TabStop = false;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(30, 433);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGreenBox.Size = new System.Drawing.Size(152, 70);
            this.btnGreenBox.TabIndex = 14;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // pbRedBox
            // 
            this.pbRedBox.BackColor = System.Drawing.Color.White;
            this.pbRedBox.BackgroundImage = global::LStanzianiQGame.Properties.Resources.red_box;
            this.pbRedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRedBox.Location = new System.Drawing.Point(34, 363);
            this.pbRedBox.Name = "pbRedBox";
            this.pbRedBox.Size = new System.Drawing.Size(60, 58);
            this.pbRedBox.TabIndex = 8;
            this.pbRedBox.TabStop = false;
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(30, 357);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRedBox.Size = new System.Drawing.Size(152, 70);
            this.btnRedBox.TabIndex = 13;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // pbGreenDoor
            // 
            this.pbGreenDoor.BackColor = System.Drawing.Color.LightGreen;
            this.pbGreenDoor.BackgroundImage = global::LStanzianiQGame.Properties.Resources.green_door;
            this.pbGreenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGreenDoor.Location = new System.Drawing.Point(34, 287);
            this.pbGreenDoor.Name = "pbGreenDoor";
            this.pbGreenDoor.Size = new System.Drawing.Size(60, 58);
            this.pbGreenDoor.TabIndex = 7;
            this.pbGreenDoor.TabStop = false;
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnGreenDoor.Location = new System.Drawing.Point(30, 281);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGreenDoor.Size = new System.Drawing.Size(152, 70);
            this.btnGreenDoor.TabIndex = 12;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // pbRedDoor
            // 
            this.pbRedDoor.BackColor = System.Drawing.Color.IndianRed;
            this.pbRedDoor.BackgroundImage = global::LStanzianiQGame.Properties.Resources.red_door;
            this.pbRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRedDoor.Location = new System.Drawing.Point(34, 211);
            this.pbRedDoor.Name = "pbRedDoor";
            this.pbRedDoor.Size = new System.Drawing.Size(60, 58);
            this.pbRedDoor.TabIndex = 6;
            this.pbRedDoor.TabStop = false;
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnRedDoor.Location = new System.Drawing.Point(30, 205);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRedDoor.Size = new System.Drawing.Size(152, 70);
            this.btnRedDoor.TabIndex = 11;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // pbWall
            // 
            this.pbWall.BackColor = System.Drawing.Color.Transparent;
            this.pbWall.BackgroundImage = global::LStanzianiQGame.Properties.Resources.Wall;
            this.pbWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbWall.InitialImage = null;
            this.pbWall.Location = new System.Drawing.Point(34, 135);
            this.pbWall.Name = "pbWall";
            this.pbWall.Size = new System.Drawing.Size(60, 58);
            this.pbWall.TabIndex = 5;
            this.pbWall.TabStop = false;
            // 
            // btnWall
            // 
            this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnWall.Location = new System.Drawing.Point(30, 129);
            this.btnWall.Name = "btnWall";
            this.btnWall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnWall.Size = new System.Drawing.Size(152, 70);
            this.btnWall.TabIndex = 10;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // pbNone
            // 
            this.pbNone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbNone.Location = new System.Drawing.Point(34, 59);
            this.pbNone.Name = "pbNone";
            this.pbNone.Size = new System.Drawing.Size(60, 58);
            this.pbNone.TabIndex = 4;
            this.pbNone.TabStop = false;
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnNone.Location = new System.Drawing.Point(30, 53);
            this.btnNone.Name = "btnNone";
            this.btnNone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNone.Size = new System.Drawing.Size(152, 70);
            this.btnNone.TabIndex = 3;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnToolBox_Click);
            // 
            // QGameDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 831);
            this.Controls.Add(this.pnlRowsColumns);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QGameDesignForm";
            this.Text = "QGameDesignForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRowsColumns.ResumeLayout(false);
            this.pnlRowsColumns.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Panel pnlRowsColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox tbColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.PictureBox pbNone;
        private System.Windows.Forms.PictureBox pbRedDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.PictureBox pbWall;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.PictureBox pbGreenBox;
        private System.Windows.Forms.PictureBox pbRedBox;
        private System.Windows.Forms.PictureBox pbGreenDoor;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
    }
}