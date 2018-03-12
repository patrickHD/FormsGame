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
        List<Control> objects = new List<Control>();
        int speed = 1;
        int speedDefault = 1;
        int speedMax = 15;
        int gravity = 9;
        Random rnd = new Random();
        long time = 0;
        long temptime = 0;

        bool fall = true;
        bool jump = false;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        bool z = false;
        bool x = false;
        bool space = false;

        float leftFor = 0;
        float rightFor = 0;

        int camerax = 0;
        int cameray = 0;
        int levelWidth = 10000;
        int winWidth;
        bool scroll = false;

        bool sf1 = false;
        bool sf2 = false;
        bool sf3 = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
            box.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            winWidth = this.Width;
            objects.Add(ruler);
            objects.Add(rulerbg);
            timer1.Start();
        }
        public void UpdateLbl()
        {
            textBox1.Text =
                $"Speed: {speed.ToString()}\r\n" +
                $"Location: {box.Xp}, {box.Yp}\r\n" +
                $"Bullets: {bullets.Count}\r\n" +
                $"Time: {time}\r\n" +
                $"TTime: {temptime}\r\n" +
                $"Falling: {fall.ToString()}\r\n" +
                $"Jump: {jump.ToString()}\r\n" +
                $"LeftFor: {leftFor / 50}\r\n" + 
                $"RghtFor: {rightFor}\r\n" +
                $"CameraX: {camerax}\r\n" +
                $"Scroll: {scroll.ToString()}\r\n" +
                $"ScrollF1: {sf1}\r\n" +
                $"ScrollF2: {sf2}\r\n" +
                $"ScrollF3: {sf3}\r\n";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(box.Xp < winWidth / 2)
            {
                sf1 = true; sf2 = false; sf3 = false;
                camerax = 0;
            }
            else if(right == true && box.Xp > levelWidth - 576 / 2)
            {
                sf2 = true; sf1 = false; sf3 = false;
                scroll = true;
                camerax = levelWidth - winWidth;
            }
            else
            {
                sf3 = true; sf2 = false; sf1 = false;
                if (right == true)
                {
                    scroll = true;
                    camerax = box.Xp - winWidth / 2;
                }
            }

            if (space == true)
            {
                jump = true;
            }
            if (box.Yp < 485)
            {
                fall = true;
            }
            else
            {
                fall = false;
            }
            if(fall == true)
            {
                jump = false;
                box.Yb -= gravity;
            }
            time++;
            UpdateLbl();
            MoveBullets();
            if ((time > temptime + 10) && z == true)
            {
                temptime = time;
                SpawnBullet();
            }
            if (left == true)
            {
                if (scroll == false) { box.Xb -= speed; }
                leftFor++;
                if(speed < speedMax)
                {
                    speed = speedDefault + (int)Math.Round(a: leftFor / 15) * 3;
                }
            }
            if (right == true)
            {
                if (scroll == false) { box.Xb += speed; }
                rightFor++;
                if (speed < speedMax)
                {
                    speed = speedDefault + (int)Math.Round(a: rightFor / 15) * 3;
                }
            }
            else if (x == true)
            {
                box.BackColor = Color.Blue;
            }
            else
            {
                box.BackColor = Color.Black;
            }
            if(jump == true)
            {
                box.Yb += 100;
                jump = false;
            }
            foreach(Control c in objects)
            {
                c.Location = new Point(c.Location.X - camerax, c.Location.Y);
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
            if(e.KeyCode == Keys.Space)
            {
                space = true;
            }
            if(e.KeyCode == Keys.X)
            {
                x = true;
            }
            if(e.KeyCode == Keys.Z)
            {
                z = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                down = true;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
            if (e.KeyCode == Keys.X)
            {
                x = false;
            }
            if (e.KeyCode == Keys.Z)
            {
                z = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                leftFor = 0;
                speed = speedDefault;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                rightFor = 0;
                speed = speedDefault;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }

        public void UpdateKeys()
        {
            lblKeys.Text = "Keys: " + string.Join(", ", keysdown);
        }

    }
}
