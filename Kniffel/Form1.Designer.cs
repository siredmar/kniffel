namespace Kniffel
{
    partial class Form1
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
            this.picDice1 = new System.Windows.Forms.PictureBox();
            this.picDice2 = new System.Windows.Forms.PictureBox();
            this.picDice3 = new System.Windows.Forms.PictureBox();
            this.picDice4 = new System.Windows.Forms.PictureBox();
            this.picDice5 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPlayer1 = new System.Windows.Forms.TabPage();
            this.tabPlayer2 = new System.Windows.Forms.TabPage();
            this.tabPlayer3 = new System.Windows.Forms.TabPage();
            this.tabPlayer4 = new System.Windows.Forms.TabPage();
            this.tabScores = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDice1
            // 
            this.picDice1.Image = global::Kniffel.Properties.Resources.three;
            this.picDice1.Location = new System.Drawing.Point(12, 288);
            this.picDice1.Name = "picDice1";
            this.picDice1.Size = new System.Drawing.Size(94, 88);
            this.picDice1.TabIndex = 0;
            this.picDice1.TabStop = false;
            this.picDice1.Tag = "0";
            this.picDice1.Click += new System.EventHandler(this.picDiceClicked);
            // 
            // picDice2
            // 
            this.picDice2.Image = global::Kniffel.Properties.Resources.three;
            this.picDice2.Location = new System.Drawing.Point(112, 288);
            this.picDice2.Name = "picDice2";
            this.picDice2.Size = new System.Drawing.Size(94, 88);
            this.picDice2.TabIndex = 1;
            this.picDice2.TabStop = false;
            this.picDice2.Tag = "1";
            this.picDice2.Click += new System.EventHandler(this.picDiceClicked);
            // 
            // picDice3
            // 
            this.picDice3.Image = global::Kniffel.Properties.Resources.three;
            this.picDice3.Location = new System.Drawing.Point(212, 288);
            this.picDice3.Name = "picDice3";
            this.picDice3.Size = new System.Drawing.Size(94, 88);
            this.picDice3.TabIndex = 2;
            this.picDice3.TabStop = false;
            this.picDice3.Tag = "2";
            this.picDice3.Click += new System.EventHandler(this.picDiceClicked);
            // 
            // picDice4
            // 
            this.picDice4.Image = global::Kniffel.Properties.Resources.three;
            this.picDice4.Location = new System.Drawing.Point(312, 288);
            this.picDice4.Name = "picDice4";
            this.picDice4.Size = new System.Drawing.Size(94, 88);
            this.picDice4.TabIndex = 3;
            this.picDice4.TabStop = false;
            this.picDice4.Tag = "3";
            this.picDice4.Click += new System.EventHandler(this.picDiceClicked);
            // 
            // picDice5
            // 
            this.picDice5.Image = global::Kniffel.Properties.Resources.three;
            this.picDice5.Location = new System.Drawing.Point(412, 288);
            this.picDice5.Name = "picDice5";
            this.picDice5.Size = new System.Drawing.Size(94, 88);
            this.picDice5.TabIndex = 4;
            this.picDice5.TabStop = false;
            this.picDice5.Tag = "4";
            this.picDice5.Click += new System.EventHandler(this.picDiceClicked);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(431, 382);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPlayer1);
            this.tabs.Controls.Add(this.tabPlayer2);
            this.tabs.Controls.Add(this.tabPlayer3);
            this.tabs.Controls.Add(this.tabPlayer4);
            this.tabs.Controls.Add(this.tabScores);
            this.tabs.Location = new System.Drawing.Point(12, 28);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(494, 254);
            this.tabs.TabIndex = 7;
            // 
            // tabPlayer1
            // 
            this.tabPlayer1.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer1.Name = "tabPlayer1";
            this.tabPlayer1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer1.Size = new System.Drawing.Size(486, 228);
            this.tabPlayer1.TabIndex = 0;
            this.tabPlayer1.Text = "Player 1";
            this.tabPlayer1.UseVisualStyleBackColor = true;
            // 
            // tabPlayer2
            // 
            this.tabPlayer2.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer2.Name = "tabPlayer2";
            this.tabPlayer2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer2.Size = new System.Drawing.Size(486, 228);
            this.tabPlayer2.TabIndex = 1;
            this.tabPlayer2.Text = "Player 2";
            this.tabPlayer2.UseVisualStyleBackColor = true;
            // 
            // tabPlayer3
            // 
            this.tabPlayer3.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer3.Name = "tabPlayer3";
            this.tabPlayer3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer3.Size = new System.Drawing.Size(486, 228);
            this.tabPlayer3.TabIndex = 2;
            this.tabPlayer3.Text = "Player 3";
            this.tabPlayer3.UseVisualStyleBackColor = true;
            // 
            // tabPlayer4
            // 
            this.tabPlayer4.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer4.Name = "tabPlayer4";
            this.tabPlayer4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer4.Size = new System.Drawing.Size(486, 228);
            this.tabPlayer4.TabIndex = 3;
            this.tabPlayer4.Text = "Player 4";
            this.tabPlayer4.UseVisualStyleBackColor = true;
            // 
            // tabScores
            // 
            this.tabScores.Location = new System.Drawing.Point(4, 22);
            this.tabScores.Name = "tabScores";
            this.tabScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabScores.Size = new System.Drawing.Size(486, 228);
            this.tabScores.TabIndex = 4;
            this.tabScores.Text = "Scores";
            this.tabScores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 415);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDice5);
            this.Controls.Add(this.picDice4);
            this.Controls.Add(this.picDice3);
            this.Controls.Add(this.picDice2);
            this.Controls.Add(this.picDice1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDice5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDice1;
        private System.Windows.Forms.PictureBox picDice2;
        private System.Windows.Forms.PictureBox picDice3;
        private System.Windows.Forms.PictureBox picDice4;
        private System.Windows.Forms.PictureBox picDice5;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPlayer1;
        private System.Windows.Forms.TabPage tabPlayer2;
        private System.Windows.Forms.TabPage tabPlayer3;
        private System.Windows.Forms.TabPage tabPlayer4;
        private System.Windows.Forms.TabPage tabScores;
    }
}

