using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper 
{
    class Cell : Button
    {
        public int Num=0;
        public int Ri,Ci;
        public bool Flag=false;
        public bool Open=false;

        public Cell(int H,int W,int r,int c)
        {
            Height = H;
            Width = W;
            Ri = r;
            Ci = c;
        }

    }
}
