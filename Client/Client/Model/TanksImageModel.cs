using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    class TanksImageModel
    {
        public Bitmap Image { get; set; }

        // Границы перемещения танка по разным направлениям //
        public BorderImageModel Mov_Left_ImageBorder { get; set; }
        public BorderImageModel Mov_Right_ImageBorder { get; set; }
        public BorderImageModel Mov_Up_ImageBorder { get; set; }
        public BorderImageModel Mov_Down_ImageBorder { get; set; }

        public TanksImageModel(
            Bitmap image,
            BorderImageModel mov_Left_ImageBorder,
            BorderImageModel mov_Right_ImageBorder,
            BorderImageModel mov_Up_ImageBorder,
            BorderImageModel mov_Down_ImageBorder)
        {
            Image = image;
            Mov_Left_ImageBorder = mov_Left_ImageBorder;
            Mov_Right_ImageBorder = mov_Right_ImageBorder;
            Mov_Up_ImageBorder = mov_Up_ImageBorder;
            Mov_Down_ImageBorder = mov_Down_ImageBorder;
        }
    }
}

