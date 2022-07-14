using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class TankModel
    {
        public Bitmap Image;
        public string Name { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; } = 5;
        public Size Size { get; set; }
        public Point Snout { get; set; }
        // 

        public Rectangle TankRectangle
        {
            get => new Rectangle(Location, Size);
        }

        public Rectangle TankImageBounds { get; set; }

        // 

        public ShotModel Shot { get; set; }

        public bool Fire { get; set; }

        public bool Alive { get; set; } = true;

        public int Health { get; set; } = 100;

        public int Damage { get; set; } = 50;

        public bool Blow { get; set; } = false;

    }
}

