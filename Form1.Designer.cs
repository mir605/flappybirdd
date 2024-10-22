namespace flappybirdd
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
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.game_menu = new System.Windows.Forms.GroupBox();
            this.scoreText_menu = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Label();
            this.scoreCopy = new System.Windows.Forms.Label();
            this.topGround = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.flyingBird = new System.Windows.Forms.PictureBox();
            this.game_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingBird)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.scoreText.Location = new System.Drawing.Point(12, 557);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(116, 27);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timerEvent);
            // 
            // game_menu
            // 
            this.game_menu.BackColor = System.Drawing.Color.Gray;
            this.game_menu.Controls.Add(this.scoreText_menu);
            this.game_menu.Controls.Add(this.exitButton);
            this.game_menu.Controls.Add(this.restart);
            this.game_menu.Controls.Add(this.scoreCopy);
            this.game_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.game_menu.Location = new System.Drawing.Point(96, 165);
            this.game_menu.Name = "game_menu";
            this.game_menu.Size = new System.Drawing.Size(243, 225);
            this.game_menu.TabIndex = 6;
            this.game_menu.TabStop = false;
            this.game_menu.Text = "menu";
            this.game_menu.Visible = false;
            this.game_menu.Enter += new System.EventHandler(this.game_menu_Enter);
            // 
            // scoreText_menu
            // 
            this.scoreText_menu.AutoSize = true;
            this.scoreText_menu.BackColor = System.Drawing.Color.Yellow;
            this.scoreText_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreText_menu.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.scoreText_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoreText_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText_menu.Location = new System.Drawing.Point(38, 70);
            this.scoreText_menu.Name = "scoreText_menu";
            this.scoreText_menu.Size = new System.Drawing.Size(161, 34);
            this.scoreText_menu.TabIndex = 8;
            this.scoreText_menu.Text = "SCORE: O";
            this.scoreText_menu.Click += new System.EventHandler(this.scoreText_menu_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(20, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(61, 27);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXİT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.Color.Lime;
            this.restart.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.restart.Location = new System.Drawing.Point(105, 134);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(119, 27);
            this.restart.TabIndex = 6;
            this.restart.Text = "RESTART";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // scoreCopy
            // 
            this.scoreCopy.AutoSize = true;
            this.scoreCopy.BackColor = System.Drawing.Color.Yellow;
            this.scoreCopy.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCopy.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.scoreCopy.Location = new System.Drawing.Point(58, 75);
            this.scoreCopy.Name = "scoreCopy";
            this.scoreCopy.Size = new System.Drawing.Size(0, 27);
            this.scoreCopy.TabIndex = 5;
            this.scoreCopy.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // topGround
            // 
            this.topGround.BackColor = System.Drawing.Color.Maroon;
            this.topGround.Location = new System.Drawing.Point(-4, -2);
            this.topGround.Name = "topGround";
            this.topGround.Size = new System.Drawing.Size(455, 49);
            this.topGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topGround.TabIndex = 5;
            this.topGround.TabStop = false;
            this.topGround.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Ground
            // 
            this.Ground.Image = global::flappybirdd.Properties.Resources._base;
            this.Ground.Location = new System.Drawing.Point(-4, 520);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(455, 34);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::flappybirdd.Properties.Resources.pipe_greendown;
            this.pipeDown.Location = new System.Drawing.Point(311, 12);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(81, 183);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            this.pipeDown.Click += new System.EventHandler(this.pipeDown_Click);
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::flappybirdd.Properties.Resources.pipe_green;
            this.pipeUp.Location = new System.Drawing.Point(311, 329);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(81, 190);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 3;
            this.pipeUp.TabStop = false;
            this.pipeUp.Click += new System.EventHandler(this.pipeUp_Click);
            // 
            // flyingBird
            // 
            this.flyingBird.Image = global::flappybirdd.Properties.Resources.yellowbird_midflap;
            this.flyingBird.Location = new System.Drawing.Point(96, 246);
            this.flyingBird.Name = "flyingBird";
            this.flyingBird.Size = new System.Drawing.Size(52, 37);
            this.flyingBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flyingBird.TabIndex = 2;
            this.flyingBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::flappybirdd.Properties.Resources.background_day;
            this.ClientSize = new System.Drawing.Size(446, 590);
            this.Controls.Add(this.game_menu);
            this.Controls.Add(this.topGround);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.flyingBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            this.game_menu.ResumeLayout(false);
            this.game_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyingBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox flyingBird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox topGround;
        private System.Windows.Forms.GroupBox game_menu;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label restart;
        private System.Windows.Forms.Label scoreCopy;
        private System.Windows.Forms.Label scoreText_menu;
    }
}

