namespace FormsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblKeys = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBulletCount = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbltTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ruler = new System.Windows.Forms.PictureBox();
            this.rulerbg = new System.Windows.Forms.PictureBox();
            this.box = new FormsGame.PlayerBox();
            ((System.ComponentModel.ISupportInitialize)(this.ruler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(12, 9);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(33, 13);
            this.lblKeys.TabIndex = 0;
            this.lblKeys.Text = "Keys:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 35);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location: ";
            // 
            // lblBulletCount
            // 
            this.lblBulletCount.AutoSize = true;
            this.lblBulletCount.Location = new System.Drawing.Point(12, 48);
            this.lblBulletCount.Name = "lblBulletCount";
            this.lblBulletCount.Size = new System.Drawing.Size(67, 13);
            this.lblBulletCount.TabIndex = 4;
            this.lblBulletCount.Text = "Bullet Count:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 61);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            // 
            // lbltTime
            // 
            this.lbltTime.AutoSize = true;
            this.lbltTime.Location = new System.Drawing.Point(12, 74);
            this.lbltTime.Name = "lbltTime";
            this.lbltTime.Size = new System.Drawing.Size(40, 13);
            this.lbltTime.TabIndex = 6;
            this.lbltTime.Text = "TTime:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 251);
            this.textBox1.TabIndex = 8;
            // 
            // ruler
            // 
            this.ruler.Image = ((System.Drawing.Image)(resources.GetObject("ruler.Image")));
            this.ruler.Location = new System.Drawing.Point(176, 35);
            this.ruler.Name = "ruler";
            this.ruler.Size = new System.Drawing.Size(9000, 100);
            this.ruler.TabIndex = 9;
            this.ruler.TabStop = false;
            // 
            // rulerbg
            // 
            this.rulerbg.Image = ((System.Drawing.Image)(resources.GetObject("rulerbg.Image")));
            this.rulerbg.Location = new System.Drawing.Point(-800, 156);
            this.rulerbg.Name = "rulerbg";
            this.rulerbg.Size = new System.Drawing.Size(9000, 282);
            this.rulerbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rulerbg.TabIndex = 10;
            this.rulerbg.TabStop = false;
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.box.Location = new System.Drawing.Point(476, 238);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(50, 50);
            this.box.TabIndex = 7;
            this.box.TabStop = false;
            this.box.Xb = 0;
            this.box.Yb = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.box);
            this.Controls.Add(this.lbltTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBulletCount);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.ruler);
            this.Controls.Add(this.rulerbg);
            this.Name = "Form1";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.ruler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulerbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBulletCount;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbltTime;
        private PlayerBox box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ruler;
        private System.Windows.Forms.PictureBox rulerbg;
    }
}

