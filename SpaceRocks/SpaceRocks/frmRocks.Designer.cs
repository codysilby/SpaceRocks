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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRocks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.tmrRock = new System.Windows.Forms.Timer(this.components);
            this.tmrRocket = new System.Windows.Forms.Timer(this.components);
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startLogo = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.PictureBox();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 26);
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
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lives";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(283, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(230, 79);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(71, 29);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLives.Location = new System.Drawing.Point(71, 48);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(13, 13);
            this.lblLives.TabIndex = 7;
            this.lblLives.Text = "5";
            // 
            // tmrRock
            // 
            this.tmrRock.Tick += new System.EventHandler(this.tmrRock_Tick);
            // 
            // tmrRocket
            // 
            this.tmrRocket.Interval = 50;
            this.tmrRocket.Tick += new System.EventHandler(this.tmrRocket_Tick);
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameTitle.Location = new System.Drawing.Point(696, 29);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(60, 13);
            this.lblNameTitle.TabIndex = 8;
            this.lblNameTitle.Text = "Your Name";
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.label4);
            this.pnlStart.Controls.Add(this.lblName2);
            this.pnlStart.Controls.Add(this.txtLives);
            this.pnlStart.Controls.Add(this.txtName);
            this.pnlStart.Controls.Add(this.label3);
            this.pnlStart.Controls.Add(this.startLogo);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(-3, -4);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(790, 639);
            this.pnlStart.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(593, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lives";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.BackColor = System.Drawing.Color.Transparent;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName2.Location = new System.Drawing.Point(158, 277);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(51, 20);
            this.lblName2.TabIndex = 9;
            this.lblName2.Text = "Name";
            // 
            // txtLives
            // 
            this.txtLives.Location = new System.Drawing.Point(570, 303);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(95, 20);
            this.txtLives.TabIndex = 8;
            this.txtLives.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLives_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 303);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(99, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(94, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 100);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // startLogo
            // 
            this.startLogo.BackgroundImage = global::SpaceRocks.Properties.Resources.header;
            this.startLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startLogo.Location = new System.Drawing.Point(52, 141);
            this.startLogo.Name = "startLogo";
            this.startLogo.Size = new System.Drawing.Size(698, 117);
            this.startLogo.TabIndex = 5;
            this.startLogo.TabStop = false;
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
            this.pnlGame.Size = new System.Drawing.Size(760, 522);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(709, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // frmRocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
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
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startLogo)).EndInit();
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
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrRock;
        private System.Windows.Forms.Timer tmrRocket;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.PictureBox startLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtLives;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

