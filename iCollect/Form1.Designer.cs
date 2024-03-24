namespace iCollect
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
            this.txtScore = new System.Windows.Forms.Label();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Apple2 = new System.Windows.Forms.PictureBox();
            this.Apple1 = new System.Windows.Forms.PictureBox();
            this.Pear1 = new System.Windows.Forms.PictureBox();
            this.Pear2 = new System.Windows.Forms.PictureBox();
            this.Banana1 = new System.Windows.Forms.PictureBox();
            this.Banana2 = new System.Windows.Forms.PictureBox();
            this.Candy = new System.Windows.Forms.PictureBox();
            this.Chocolate = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Candy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chocolate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(12, 30);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(94, 25);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.Blue;
            this.Wall1.Location = new System.Drawing.Point(188, -6);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(32, 173);
            this.Wall1.TabIndex = 1;
            this.Wall1.TabStop = false;
            this.Wall1.Tag = "wall";
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Blue;
            this.Wall2.Location = new System.Drawing.Point(522, -6);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(32, 173);
            this.Wall2.TabIndex = 1;
            this.Wall2.TabStop = false;
            this.Wall2.Tag = "wall";
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.Blue;
            this.Wall3.Location = new System.Drawing.Point(127, 475);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(32, 173);
            this.Wall3.TabIndex = 1;
            this.Wall3.TabStop = false;
            this.Wall3.Tag = "wall";
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.Blue;
            this.Wall4.Location = new System.Drawing.Point(505, 475);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(32, 173);
            this.Wall4.TabIndex = 1;
            this.Wall4.TabStop = false;
            this.Wall4.Tag = "wall";
            // 
            // Player
            // 
            this.Player.Image = global::iCollect.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(31, 109);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 58);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // Apple2
            // 
            this.Apple2.Image = global::iCollect.Properties.Resources.apple;
            this.Apple2.Location = new System.Drawing.Point(606, 308);
            this.Apple2.Name = "Apple2";
            this.Apple2.Size = new System.Drawing.Size(61, 51);
            this.Apple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Apple2.TabIndex = 2;
            this.Apple2.TabStop = false;
            this.Apple2.Tag = "fruit";
            // 
            // Apple1
            // 
            this.Apple1.Image = global::iCollect.Properties.Resources.apple;
            this.Apple1.Location = new System.Drawing.Point(433, 63);
            this.Apple1.Name = "Apple1";
            this.Apple1.Size = new System.Drawing.Size(61, 51);
            this.Apple1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Apple1.TabIndex = 2;
            this.Apple1.TabStop = false;
            this.Apple1.Tag = "fruit";
            // 
            // Pear1
            // 
            this.Pear1.Image = global::iCollect.Properties.Resources.pear;
            this.Pear1.Location = new System.Drawing.Point(200, 529);
            this.Pear1.Name = "Pear1";
            this.Pear1.Size = new System.Drawing.Size(61, 51);
            this.Pear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pear1.TabIndex = 2;
            this.Pear1.TabStop = false;
            this.Pear1.Tag = "fruit";
            // 
            // Pear2
            // 
            this.Pear2.Image = global::iCollect.Properties.Resources.pear;
            this.Pear2.Location = new System.Drawing.Point(587, 503);
            this.Pear2.Name = "Pear2";
            this.Pear2.Size = new System.Drawing.Size(61, 51);
            this.Pear2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pear2.TabIndex = 2;
            this.Pear2.TabStop = false;
            this.Pear2.Tag = "fruit";
            // 
            // Banana1
            // 
            this.Banana1.Image = global::iCollect.Properties.Resources.banana;
            this.Banana1.Location = new System.Drawing.Point(380, 529);
            this.Banana1.Name = "Banana1";
            this.Banana1.Size = new System.Drawing.Size(61, 51);
            this.Banana1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banana1.TabIndex = 2;
            this.Banana1.TabStop = false;
            this.Banana1.Tag = "fruit";
            // 
            // Banana2
            // 
            this.Banana2.Image = global::iCollect.Properties.Resources.banana;
            this.Banana2.Location = new System.Drawing.Point(606, 86);
            this.Banana2.Name = "Banana2";
            this.Banana2.Size = new System.Drawing.Size(61, 51);
            this.Banana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banana2.TabIndex = 2;
            this.Banana2.TabStop = false;
            this.Banana2.Tag = "fruit";
            // 
            // Candy
            // 
            this.Candy.Image = global::iCollect.Properties.Resources.candy;
            this.Candy.Location = new System.Drawing.Point(264, 63);
            this.Candy.Name = "Candy";
            this.Candy.Size = new System.Drawing.Size(67, 63);
            this.Candy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Candy.TabIndex = 2;
            this.Candy.TabStop = false;
            this.Candy.Tag = "sugar";
            // 
            // Chocolate
            // 
            this.Chocolate.Image = global::iCollect.Properties.Resources.chocolate;
            this.Chocolate.Location = new System.Drawing.Point(200, 254);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(67, 63);
            this.Chocolate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Chocolate.TabIndex = 2;
            this.Chocolate.TabStop = false;
            this.Chocolate.Tag = "sugar";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.runTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 643);
            this.Controls.Add(this.Candy);
            this.Controls.Add(this.Chocolate);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.Banana2);
            this.Controls.Add(this.Banana1);
            this.Controls.Add(this.Pear2);
            this.Controls.Add(this.Pear1);
            this.Controls.Add(this.Apple1);
            this.Controls.Add(this.Apple2);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Name = "Form1";
            this.Text = "iCollect";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressedKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.releasedKey);
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Candy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chocolate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Wall1;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox Wall3;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Apple2;
        private System.Windows.Forms.PictureBox Apple1;
        private System.Windows.Forms.PictureBox Pear1;
        private System.Windows.Forms.PictureBox Pear2;
        private System.Windows.Forms.PictureBox Banana1;
        private System.Windows.Forms.PictureBox Banana2;
        private System.Windows.Forms.PictureBox Candy;
        private System.Windows.Forms.PictureBox Chocolate;
        private System.Windows.Forms.Timer gameTimer;
    }
}

