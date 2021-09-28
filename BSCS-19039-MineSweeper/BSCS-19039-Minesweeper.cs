using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Sweeper
{
    public partial class Minesweeper : Form
    {
        int Dim=0;
        int NOM=0;
        Cell[,] Cs;
        public Minesweeper()
        {
            InitializeComponent();
        }

        private void LoadCells()
        {
            Cs = new Cell[Dim,Dim];
            int H = Board.Height/Dim-6;
            int W = Board.Width / Dim - 6;
            for (int ri = 0; ri < Dim; ri++)
            {
                for (int ci = 0; ci < Dim; ci++)
                {
                    Cell C=new Cell(H,W,ri,ci);
                 //   C.BackgroundImage = Properties.Resources._1Bomb;
                    C.Click += new System.EventHandler(Cell_Clicked);
                    Board.Controls.Add(C);          
                    Cs[ri, ci] = C;
                }
            }
            InitMines();
        }


        private void InitMines()
        {
            Random R = new Random();
            for(int i=0;i<NOM;i++)
            {
                int r = R.Next(Dim);
                int c = R.Next(Dim);
                if (Cs[r, c].Num != -1)
                    Cs[r, c].Num = -1;
                else
                {
                    i--;
                    continue;
                }
                Cs[r, c].Text = Cs[r, c].Num.ToString();
            }
            for(int Ri=0;Ri<Dim;Ri++)
            {
                for(int Ci=0;Ci<Dim;Ci++)
                {
                    if (Cs[Ri, Ci].Num!=-1)
                    {
                        Cs[Ri, Ci].Num = WindowMinesCount(Ri, Ci);
                        Cs[Ri, Ci].Text = Cs[Ri, Ci].Num.ToString();
                    }
                }
            }
        }

        private int WindowMinesCount(int R,int C)
        {
            int Count=0;
            for(int ri=R-1;ri<R+1;ri++)
            {
                for (int ci = C - 1; ci < C + 1; ci++)
                {
                    if ((ri == R && ci == C) || ri < 0 || ci < 0 || ri >= Dim || ci >= Dim)
                        continue;
                    if (Cs[ri, ci].Num == -1)
                        Count++;
                }
            }
            return Count;
        }


        void Explore(int ri, int ci)
        {
            if (Cs[ri, ci].Open == true) return;

            Cs[ri, ci].Open = true;

            for (int r = ri - 1; r <= ri + 1; r++)
            {
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if (r < 0 || r >= Dim || c < 0 || c >= Dim) continue;
                    
                    if (Cs[r, c].Open == false)
                    {
                        if (Cs[r, c].Num != 0)
                        {
                            Cs[r, c].Text = Cs[r, c].Num.ToString();
                            Cs[r, c].Open = true;
                        }
                        else if (Cs[r, c].Num == 0)
                        {
                            Explore(r, c);
                            Cs[r, c].BackColor = Color.Gray;
                        }
                   }
                }
            }
        }


        private void Cell_Clicked(object sender, EventArgs e)
        {
            Cell C = (Cell)sender;
            MouseEventArgs ME = (MouseEventArgs)e;

            if(ME.Button==MouseButtons.Right)
            {
                C.BackColor = Color.Red;
                C.Flag = true;
            }

            if(C.Flag)
                return;
            if (C.Open)
                return;


            if(C.Num==-1)
            {
                MessageBox.Show("Game Over");
                // Diasplay all mines
            }
            else if(C.Num!=0)
            {
                C.Text = C.Num.ToString();
                C.Open = true;
            }
            else
            {
             //  Explore(C.Ri, C.Ci);
            }
            //C.BackgroundImage = Properties.Resources._0;
        }

        private void Start_Clicked(object sender, EventArgs e)
        {
            if (Beginner.Checked)
            {
                Dim = 9;
                NOM = 10;
            }
                
            if (Intermediate.Checked)
            {
                Dim = 15;
                NOM = 10;
            }
            if (Expert.Checked)
            {
                Dim = 25;
                NOM = 10;
            }
            if(Dim==0)
            {
                MessageBox.Show("Select An Option....!!!");
                return;
            }
            panel1.Hide();
            LoadCells();
        }

      

    }
}
