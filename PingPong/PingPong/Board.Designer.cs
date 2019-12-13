namespace PingPong
{
    partial class Board
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(12, 102);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(22, 174);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Red;
            this.cpu.Location = new System.Drawing.Point(850, 102);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(22, 174);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Chartreuse;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Location = new System.Drawing.Point(430, 177);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // cpuScore
            // 
            this.cpuScore.AutoSize = true;
            this.cpuScore.BackColor = System.Drawing.SystemColors.InfoText;
            this.cpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cpuScore.ForeColor = System.Drawing.Color.Red;
            this.cpuScore.Location = new System.Drawing.Point(667, 13);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(64, 46);
            this.cpuScore.TabIndex = 3;
            this.cpuScore.Text = "00";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.SystemColors.InfoText;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(193, 13);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(64, 46);
            this.playerScore.TabIndex = 4;
            this.playerScore.Text = "00";
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Name = "Board";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label cpuScore;
        private System.Windows.Forms.Label playerScore;
    }
}

