using Client.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Controller
{
    class TankControl
    {

        public TankControl(TanksImageModel tanksImage)
        {
            Tank = new TankModel();
            Tank.Shot = new ShotModel();

            TanksImage = tanksImage;

            Tank.Image = TanksImage.Image;
            Tank.Image.MakeTransparent();

            Tank.Size = new Size(TanksImage.Mov_Right_ImageBorder.Width / 4, TanksImage.Mov_Right_ImageBorder.Height / 4);

            Tank.TankImageBounds = TanksImage.Mov_Right_ImageBorder.Rectangle;
            currentMove = MoveRight;

            Tank.Snout = new Point(Tank.Location.X + Tank.Size.Width, Tank.Location.Y + Tank.Size.Height / 2);

            Tank.Shot.Location = Tank.Snout;

        }
        private Func<Point, Rectangle> currentMove;


                                                      // Движения снаряда //
        private void MoveShow(Action move)
        {
            Task.Factory.StartNew(() =>
            {
                while (FieldBorder.Contains(Tank.Shot.Location))
                {
                    if (!Tank.Shot.Run)
                    {
                        break;
                    }

                    move();
                    Thread.Sleep(100);
                }
                Tank.Fire = false;
                Tank.Shot.Run = false;
                Tank.Shot.Location = Tank.Snout;
            });
        }
                                      // Направления
        public enum Directions
        {
            Left,
            Right,
            Up,
            Down
        }
                                      // 
        public Point NextPoint(Directions direction)
        {
            Point point = new Point();
            switch (direction)
            {
                // LEFT
                case Directions.Left:
                    if (Tank.Location.X - Tank.Speed >= FieldBorder.Location.X)
                    {
                        point = new Point(Tank.Location.X - Tank.Speed, Tank.Location.Y);
                    }
                    else
                    {
                        point = new Point(FieldBorder.Location.X, Tank.Location.Y);
                    }
                    break;
                // RIGHT
                case Directions.Right:
                    if (Tank.Location.X + Tank.Speed + Tank.Size.Width <= FieldBorder.Location.X + FieldBorder.Width)
                    {
                        point = new Point(Tank.Location.X + Tank.Speed, Tank.Location.Y);
                    }
                    else
                    {
                        point = new Point(FieldBorder.Location.X + FieldBorder.Width - Tank.Size.Width, Tank.Location.Y);
                    }
                    break;
                    // UP
                case Directions.Up:
                    if (Tank.Location.Y - Tank.Speed >= FieldBorder.Location.Y)
                    {
                        point = new Point(Tank.Location.X, Tank.Location.Y - Tank.Speed);
                    }
                    else
                    {
                        point = new Point(Tank.Location.X, FieldBorder.Location.Y);
                    }
                    break;
                    // DOWN
                case Directions.Down:
                    if (Tank.Location.Y + Tank.Speed + Tank.Size.Height <= FieldBorder.Location.Y + FieldBorder.Height)
                    {
                        point = new Point(Tank.Location.X, Tank.Location.Y + Tank.Speed);
                    }
                    else
                    {
                        point = new Point(Tank.Location.X, FieldBorder.Location.Y + FieldBorder.Height - Tank.Size.Height);
                    }
                    break;
            }
            return point;
        }


























        public TankModel Tank { get; private set; }
        public Rectangle FieldBorder { get; set; }
        public TanksImageModel TanksImage { get; protected set; }
    }
  
}
