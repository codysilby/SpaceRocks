namespace SpaceRocks
{
    partial class frmRocks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrRock = new System.Windows.Forms.Timer(this.components);
            this.tmrRocket = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Heading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lives";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(686, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = " Let\'s Go!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(686, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Let\'s Stop!";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(59, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLives.Location = new System.Drawing.Point(59, 31);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(13, 13);
            this.lblLives.TabIndex = 7;
            this.lblLives.Text = "5";
            // 
            // Heading
            // 
            this.Heading.BackgroundImage = global::SpaceRocks.Properties.Resources.header;
            this.Heading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heading.Location = new System.Drawing.Point(110, 4);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(560, 90);
            this.Heading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heading.TabIndex = 1;
            this.Heading.TabStop = false;
            // 
            // pnlGame
            // 
            this.pnlGame.BackgroundImage = global::SpaceRocks.Properties.Resources.background;
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlGame.Location = new System.Drawing.Point(12, 100);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(760, 449);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // tmrRock
            // 
            this.tmrRock.Enabled = true;
            this.tmrRock.Tick += new System.EventHandler(this.tmrRock_Tick);
            // 
            // tmrRocket
            // 
            this.tmrRocket.Enabled = true;
            this.tmrRocket.Interval = 50;
            this.tmrRocket.Tick += new System.EventHandler(this.tmrRocket_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(22, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Your Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // frmRocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.pnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmRocks";
            this.Text = "SpaceRocks";
            this.Load += new System.EventHandler(this.frmRocks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRocks_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRocks_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Heading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.PictureBox Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrRock;
        private System.Windows.Forms.Timer tmrRocket;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}

