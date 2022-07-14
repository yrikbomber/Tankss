using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class ShotModel
    {
        public void MoveLeft()
        {
            Location = new Point(Location.X - Speed, Location.Y);
        }

        public void MoveRight()
        {
            Location = new Point(Location.X + Speed, Location.Y);
        }

        public void MoveUp()
        {
            Location = new Point(Location.X, Location.Y - Speed);
        }

        public void MoveDown()
        {
            Location = new Point(Location.X, Location.Y + Speed);
        }

        public Point Location { get; set; }

        public int Speed { get; set; } = 15;

        public bool Run { get; set; } = false;


    }
}

