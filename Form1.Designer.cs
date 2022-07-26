namespace Math_Shooter_Game
{
    partial class gameWorldForm
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
            this.components = new System.ComponentModel.Container();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.exercisePanel = new System.Windows.Forms.Panel();
            this.answerTxt = new System.Windows.Forms.Label();
            this.problemTxt = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            this.winnerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trophyBox = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.exercisePanel.SuspendLayout();
            this.winnerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAmmo.Location = new System.Drawing.Point(12, 8);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtScore.Location = new System.Drawing.Point(284, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(88, 24);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHealth.Location = new System.Drawing.Point(544, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(76, 24);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(626, 9);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(162, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainTimerEvents);
            // 
            // exercisePanel
            // 
            this.exercisePanel.BackColor = System.Drawing.Color.White;
            this.exercisePanel.Controls.Add(this.answerTxt);
            this.exercisePanel.Controls.Add(this.problemTxt);
            this.exercisePanel.Location = new System.Drawing.Point(298, 172);
            this.exercisePanel.Name = "exercisePanel";
            this.exercisePanel.Size = new System.Drawing.Size(220, 50);
            this.exercisePanel.TabIndex = 5;
            // 
            // answerTxt
            // 
            this.answerTxt.AutoSize = true;
            this.answerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxt.Location = new System.Drawing.Point(142, 6);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(55, 37);
            this.answerTxt.TabIndex = 4;
            this.answerTxt.Text = "00";
            // 
            // problemTxt
            // 
            this.problemTxt.AutoSize = true;
            this.problemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTxt.Location = new System.Drawing.Point(3, 6);
            this.problemTxt.Name = "problemTxt";
            this.problemTxt.Size = new System.Drawing.Size(133, 37);
            this.problemTxt.TabIndex = 2;
            this.problemTxt.Text = "00+00=";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.ForeColor = System.Drawing.Color.Yellow;
            this.levelLbl.Location = new System.Drawing.Point(444, 8);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(94, 24);
            this.levelLbl.TabIndex = 6;
            this.levelLbl.Text = "Level: 01";
            this.levelLbl.Click += new System.EventHandler(this.levelLbl_Click);
            // 
            // winnerPanel
            // 
            this.winnerPanel.BackColor = System.Drawing.Color.White;
            this.winnerPanel.Controls.Add(this.label1);
            this.winnerPanel.Controls.Add(this.trophyBox);
            this.winnerPanel.Location = new System.Drawing.Point(16, 35);
            this.winnerPanel.Name = "winnerPanel";
            this.winnerPanel.Size = new System.Drawing.Size(772, 403);
            this.winnerPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(302, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "You Win !";
            // 
            // trophyBox
            // 
            this.trophyBox.Image = global::Math_Shooter_Game.Properties.Resources.Trophy_Animated;
            this.trophyBox.Location = new System.Drawing.Point(197, 14);
            this.trophyBox.Name = "trophyBox";
            this.trophyBox.Size = new System.Drawing.Size(385, 321);
            this.trophyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophyBox.TabIndex = 1;
            this.trophyBox.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Math_Shooter_Game.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(361, 338);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // gameWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winnerPanel);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.exercisePanel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Name = "gameWorldForm";
            this.Text = "Math Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.exercisePanel.ResumeLayout(false);
            this.exercisePanel.PerformLayout();
            this.winnerPanel.ResumeLayout(false);
            this.winnerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel exercisePanel;
        private System.Windows.Forms.Label problemTxt;
        private System.Windows.Forms.Label answerTxt;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Panel winnerPanel;
        private System.Windows.Forms.PictureBox trophyBox;
        private System.Windows.Forms.Label label1;
    }
}

