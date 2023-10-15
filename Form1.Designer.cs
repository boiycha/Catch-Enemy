namespace Brick_Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lScore = new System.Windows.Forms.Label();
            this.pLife3 = new System.Windows.Forms.PictureBox();
            this.pLife2 = new System.Windows.Forms.PictureBox();
            this.pLife1 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.lOver = new System.Windows.Forms.Label();
            this.lHigh = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.gMenu = new System.Windows.Forms.GroupBox();
            this.lQuit = new System.Windows.Forms.Label();
            this.lRestart = new System.Windows.Forms.Label();
            this.lPause = new System.Windows.Forms.Label();
            this.gPause = new System.Windows.Forms.GroupBox();
            this.lQuit2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.gMenu.SuspendLayout();
            this.gPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(12, 44);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(106, 27);
            this.lScore.TabIndex = 2;
            this.lScore.Text = "Score : 0";
            // 
            // pLife3
            // 
            this.pLife3.Image = global::Brick_Game.Properties.Resources.icons8_heart_suit_48;
            this.pLife3.Location = new System.Drawing.Point(313, 12);
            this.pLife3.Name = "pLife3";
            this.pLife3.Size = new System.Drawing.Size(48, 48);
            this.pLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pLife3.TabIndex = 5;
            this.pLife3.TabStop = false;
            // 
            // pLife2
            // 
            this.pLife2.Image = global::Brick_Game.Properties.Resources.icons8_heart_suit_48;
            this.pLife2.Location = new System.Drawing.Point(249, 12);
            this.pLife2.Name = "pLife2";
            this.pLife2.Size = new System.Drawing.Size(48, 48);
            this.pLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pLife2.TabIndex = 4;
            this.pLife2.TabStop = false;
            // 
            // pLife1
            // 
            this.pLife1.Image = global::Brick_Game.Properties.Resources.icons8_heart_suit_48;
            this.pLife1.Location = new System.Drawing.Point(183, 12);
            this.pLife1.Name = "pLife1";
            this.pLife1.Size = new System.Drawing.Size(48, 48);
            this.pLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pLife1.TabIndex = 3;
            this.pLife1.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.Image = global::Brick_Game.Properties.Resources.icons8_eight_pointed_star_48__1_;
            this.enemy.Location = new System.Drawing.Point(227, 95);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(48, 48);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemy.TabIndex = 1;
            this.enemy.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Brick_Game.Properties.Resources.icons8_chimpanzee_48;
            this.player.Location = new System.Drawing.Point(121, 331);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 48);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // lOver
            // 
            this.lOver.AutoSize = true;
            this.lOver.Font = new System.Drawing.Font("Imprint MT Shadow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lOver.Location = new System.Drawing.Point(24, 24);
            this.lOver.Name = "lOver";
            this.lOver.Size = new System.Drawing.Size(261, 51);
            this.lOver.TabIndex = 6;
            this.lOver.Text = "Game-Over ";
            // 
            // lHigh
            // 
            this.lHigh.AutoSize = true;
            this.lHigh.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHigh.Location = new System.Drawing.Point(12, 86);
            this.lHigh.Name = "lHigh";
            this.lHigh.Size = new System.Drawing.Size(141, 27);
            this.lHigh.TabIndex = 7;
            this.lHigh.Text = "HighScore :";
            this.lHigh.Click += new System.EventHandler(this.label1_Click);
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValue.Location = new System.Drawing.Point(169, 86);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(25, 27);
            this.lValue.TabIndex = 8;
            this.lValue.Text = "0";
            // 
            // gMenu
            // 
            this.gMenu.Controls.Add(this.lQuit);
            this.gMenu.Controls.Add(this.lRestart);
            this.gMenu.Controls.Add(this.lOver);
            this.gMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gMenu.Location = new System.Drawing.Point(31, 149);
            this.gMenu.Name = "gMenu";
            this.gMenu.Size = new System.Drawing.Size(330, 176);
            this.gMenu.TabIndex = 9;
            this.gMenu.TabStop = false;
            this.gMenu.Text = "Menu";
            // 
            // lQuit
            // 
            this.lQuit.AutoSize = true;
            this.lQuit.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuit.Location = new System.Drawing.Point(119, 124);
            this.lQuit.Name = "lQuit";
            this.lQuit.Size = new System.Drawing.Size(61, 27);
            this.lQuit.TabIndex = 11;
            this.lQuit.Text = "Quit";
            this.lQuit.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lRestart
            // 
            this.lRestart.AutoSize = true;
            this.lRestart.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRestart.Location = new System.Drawing.Point(104, 85);
            this.lRestart.Name = "lRestart";
            this.lRestart.Size = new System.Drawing.Size(89, 27);
            this.lRestart.TabIndex = 10;
            this.lRestart.Text = "Restart";
            this.lRestart.Click += new System.EventHandler(this.lRestart_Click);
            // 
            // lPause
            // 
            this.lPause.AutoSize = true;
            this.lPause.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPause.Location = new System.Drawing.Point(308, 352);
            this.lPause.Name = "lPause";
            this.lPause.Size = new System.Drawing.Size(31, 27);
            this.lPause.TabIndex = 12;
            this.lPause.Text = "| |";
            this.lPause.Click += new System.EventHandler(this.lPause_Click);
            // 
            // gPause
            // 
            this.gPause.Controls.Add(this.label3);
            this.gPause.Controls.Add(this.lQuit2);
            this.gPause.Controls.Add(this.label2);
            this.gPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gPause.Location = new System.Drawing.Point(31, 149);
            this.gPause.Name = "gPause";
            this.gPause.Size = new System.Drawing.Size(330, 176);
            this.gPause.TabIndex = 12;
            this.gPause.TabStop = false;
            this.gPause.Text = "Pause menu";
            // 
            // lQuit2
            // 
            this.lQuit2.AutoSize = true;
            this.lQuit2.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuit2.Location = new System.Drawing.Point(126, 124);
            this.lQuit2.Name = "lQuit2";
            this.lQuit2.Size = new System.Drawing.Size(61, 27);
            this.lQuit2.TabIndex = 11;
            this.lQuit2.Text = "Quit";
            this.lQuit2.Click += new System.EventHandler(this.lQuit2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Restart";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Continue";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.gPause);
            this.Controls.Add(this.lPause);
            this.Controls.Add(this.gMenu);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lHigh);
            this.Controls.Add(this.pLife3);
            this.Controls.Add(this.pLife2);
            this.Controls.Add(this.pLife1);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.gMenu.ResumeLayout(false);
            this.gMenu.PerformLayout();
            this.gPause.ResumeLayout(false);
            this.gPause.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.PictureBox pLife1;
        private System.Windows.Forms.PictureBox pLife2;
        private System.Windows.Forms.PictureBox pLife3;
        private System.Windows.Forms.Label lOver;
        private System.Windows.Forms.Label lHigh;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.GroupBox gMenu;
        private System.Windows.Forms.Label lQuit;
        private System.Windows.Forms.Label lRestart;
        private System.Windows.Forms.Label lPause;
        private System.Windows.Forms.GroupBox gPause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lQuit2;
        private System.Windows.Forms.Label label2;
    }
}

