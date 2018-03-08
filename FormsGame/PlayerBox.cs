using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGame
{
    public partial class PlayerBox : PictureBox
    {
        public int Xb
        {
            get
            {
                return 0;
            }
            set
            {
                this.Location = new Point(this.Location.X + value, this.Location.Y);
            }
        }
        public int Yb
        {
            get
            {
                return 0;
            }
            set
            {
                this.Location = new Point(this.Location.X, this.Location.Y - value);
            }
        }

        public int Xp
        {
            get
            {
                return this.Location.X;
            }
        }

        public int Yp
        {
            get
            {
                return this.Location.Y;
            }
        }
    }
}
