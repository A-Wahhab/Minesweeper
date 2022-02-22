using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Cell:Button
    {
        public int Num = 0, ri, ci;
        public bool isOpen = false, Flag = false;
        public Cell(int r, int c, int H, int W)
        {
            this.Height = H;
            this.Width = W;
            ri = r;
            ci = c;
        }
    }
}
