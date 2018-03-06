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
        int bcnt = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSpeed.Text = "Speed: " + speed.ToString();
            lblLocation.Text = "Location: " + box.Location.X.ToString() + ", " + box.Location.Y.ToString();
            lblBulletCount.Text = "Bullet Count: " + bullets.Count;
            if (keysdown.Contains(Keys.Up.ToString()))
            {
                box.Location = new Point(box.Location.X, box.Location.Y - speed);
            }
            if (keysdown.Contains(Keys.Down.ToString()))
            {
                box.Location = new Point(box.Location.X, box.Location.Y + speed);
            }
            if (keysdown.Contains(Keys.Left.ToString()))
            {
                box.Location = new Point(box.Location.X - speed, box.Location.Y);
            }
            if (keysdown.Contains(Keys.Right.ToString()))
            {
                box.Location = new Point(box.Location.X + speed, box.Location.Y);
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
                box.BackColor = Color.Yellow;
            }
            if (bcnt >= 10)
            {
                bcnt = 0;
            }
            else
            {
                bcnt++;
            }
            if (keysdown.Contains(Keys.Space.ToString()) && (bcnt == 0))
            {
                SpawnBullet();
            }
            MoveBullets();
            
        }

        public void SpawnBullet()
        {
            PictureBox bullet = new PictureBox
            {
                Anchor = (AnchorStyles.Bottom | AnchorStyles.Left),
                Location = new Point(box.Location.X, box.Location.Y),
                Size = new Size(25, 25),
                BackColor = Color.Black
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
            if (e.KeyCode == Keys.Space)
                bcnt = 0;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
