using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGame
{
    public partial class Form1 : Form
    {
        List<string> keysdown = new List<string>();
        List<PictureBox> bullets = new List<PictureBox>();
        int speed = 5;
        int gravity = 9;
        Random rnd = new Random();
        long time = 0;
        long temptime = 0;

        bool fall = true;
        bool jump = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
            box.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            timer1.Start();
        }
        public void UpdateLbl()
        {
            lblSpeed.Text = "Speed: " + speed.ToString();
            lblLocation.Text = "Location: " + box.Location.X.ToString() + ", " + box.Location.Y.ToString();
            lblBulletCount.Text = "Bullet Count: " + bullets.Count;
            lblTime.Text = "Time: " + time;
            lbltTime.Text = "TTime: " + temptime;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(box.Yp < 500)
            {
                fall = true;
            }
            else
            {
                fall = false;
            }
            if(fall == true)
            {
                box.Yb -= gravity;
            }
            time++;
            UpdateLbl();
            MoveBullets();
            if ((time > temptime + 10) && keysdown.Contains(Keys.Space.ToString()))
            {
                temptime = time;
                SpawnBullet();
            }
            if (keysdown.Contains(Keys.Up.ToString()))
            {
                box.Yb += speed;
            }
            if (keysdown.Contains(Keys.Down.ToString()))
            {
                box.Yb -= speed;
            }
            if (keysdown.Contains(Keys.Left.ToString()))
            {
                box.Xb -= speed;
            }
            if (keysdown.Contains(Keys.Right.ToString()))
            {
                box.Xb += speed;
            }
            if (keysdown.Contains(Keys.Z.ToString()))
            {
                box.BackColor = Color.Red;
            }
            else if (keysdown.Contains(Keys.X.ToString()))
            {
                box.BackColor = Color.Blue;
            }
            else
            {
                box.BackColor = Color.Black;
            }
        }

        public void SpawnBullet()
        {
            PictureBox bullet = new PictureBox
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Location = new Point(box.Location.X, box.Location.Y),
                Size = new Size(25, 25),
                BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
            };

            bullets.Add(bullet);
            Controls.Add(bullet);
        }

        public void MoveBullets()
        {
            if (bullets.Count > 0)
            {
                lblSpeed.Text = bullets.Last().Location.Y.ToString();
                foreach (PictureBox bullet in bullets.ToList())
                {
                    bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 5);
                    if (bullet.Location.Y < 25)
                    {
                        Controls.Remove(bullet);
                        bullets.Remove(bullet);
                    }
                }
            }
        }
        
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (!keysdown.Contains(e.KeyCode.ToString()))
                keysdown.Add(e.KeyCode.ToString());
            UpdateKeys();
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (keysdown.Contains(e.KeyCode.ToString()))
                keysdown.Remove(e.KeyCode.ToString());
            UpdateKeys();
        }

        public void UpdateKeys()
        {
            lblKeys.Text = "Keys: " + string.Join(", ", keysdown);
        }

    }
}
