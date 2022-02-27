namespace TicTacToe
{
    partial class TicTacToeForm
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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playVsAnotherPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.playWithToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGame);
            // 
            // playWithToolStripMenuItem
            // 
            this.playWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playVsComputerToolStripMenuItem,
            this.playVsAnotherPlayerToolStripMenuItem});
            this.playWithToolStripMenuItem.Name = "playWithToolStripMenuItem";
            this.playWithToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.playWithToolStripMenuItem.Text = "Play with";
            // 
            // playVsComputerToolStripMenuItem
            // 
            this.playVsComputerToolStripMenuItem.Name = "playVsComputerToolStripMenuItem";
            this.playVsComputerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playVsComputerToolStripMenuItem.Text = "Play vs Computer";
            this.playVsComputerToolStripMenuItem.Click += new System.EventHandler(this.PlayVsComputer_Click);
            // 
            // playVsAnotherPlayerToolStripMenuItem
            // 
            this.playVsAnotherPlayerToolStripMenuItem.Name = "playVsAnotherPlayerToolStripMenuItem";
            this.playVsAnotherPlayerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.playVsAnotherPlayerToolStripMenuItem.Text = "Play vs Another Player";
            this.playVsAnotherPlayerToolStripMenuItem.Click += new System.EventHandler(this.PlayVsAnotherPlayer_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.GameExit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.authorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.Rules);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.Author);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(12, 40);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.ButtonClick);
            this.A1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(93, 40);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.ButtonClick);
            this.A2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(174, 40);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.ButtonClick);
            this.A3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(12, 121);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.ButtonClick);
            this.B1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(93, 121);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.ButtonClick);
            this.B2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(174, 121);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.ButtonClick);
            this.B3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(12, 202);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.ButtonClick);
            this.C1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(93, 202);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.ButtonClick);
            this.C2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(174, 202);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.ButtonClick);
            this.C3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Location = new System.Drawing.Point(38, 317);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(13, 13);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            this.x_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Location = new System.Drawing.Point(124, 317);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(13, 13);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            this.draw_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Location = new System.Drawing.Point(209, 317);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(13, 13);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            this.o_win_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(12, 292);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(71, 20);
            this.p1.TabIndex = 16;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(178, 292);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(71, 20);
            this.p2.TabIndex = 17;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.ComputerCheck);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 340);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.ToolStripMenuItem playWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playVsAnotherPlayerToolStripMenuItem;
    }
}

