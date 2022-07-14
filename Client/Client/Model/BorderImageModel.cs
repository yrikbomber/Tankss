using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class BorderImageModel
    {
        public int S_X { get; }
        public int S_Y { get; }
        public int Width { get; }
        public int Height { get; }
        public BorderImageModel(int s_tX, int s_Y, int width, int height)
        {
            S_X = s_tX;
            S_Y = s_Y;
            Width = width;
            Height = height;
        }
        // лучший вариант, нашёл в гугле)
        public Rectangle Rectangle
        {
            get => new Rectangle(S_X, S_Y, Width, Height);
        }

    }
}
