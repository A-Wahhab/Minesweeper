using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        private int t;
        int Dim = 0, NoMines = 0;
        Cell[,] Cs;
        public Minesweeper()
        {
            InitializeComponent();
        }
        private void LoadCell()
        {
            Board.Controls.Clear();
            Cs = new Cell[Dim, Dim];
            int H = Board.Height / Dim - 6;
            int W = Board.Width / Dim - 6;
            for(int ri=0;ri<Dim;ri++)
            {
                for (int ci = 0; ci < Dim; ci++)
                {
                    Cell C = new Cell(ri, ci, H, W);
                    C.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cell_Click);
                    Board.Controls.Add(C);
                    Cs[ri, ci] = C;
                }
            }
            MineLoad();
        }
        private void MineLoad()
        {
            Random Rnd = new Random();
            for (int i=0;i<NoMines;i++)
            {
                int ri = Rnd.Next(Dim);
                int ci = Rnd.Next(Dim);
                if (Cs[ri, ci].Num == -1)
                {
                    i--;
                    continue;
                }
                Cs[ri, ci].Num = -1;
              //  Cs[ri, ci].Text = Cs[ri, ci].Num.ToString();
            }
            for (int ri = 0; ri < Dim; ri++)
            {
                for (int ci = 0; ci < Dim; ci++)
                {
                    if (Cs[ri, ci].Num == -1)
                        continue;
                    int MinesCount = WindowCount(ri, ci);
                    Cs[ri, ci].Num = MinesCount;
                //    Cs[ri, ci].Text = Cs[ri, ci].Num.ToString();
                }
            }
        }
        int WindowCount(int ri,int ci)
        {
            int count = 0;
            for (int r = ri - 1; r <= ri + 1; r++)
            {
                for (int c = ci - 1; c <= ci + 1; c++)
                {
                    if ((r == ri && c == ci) || r < 0 || c < 0 || r >= Dim || c >= Dim)
                        continue;
                    if (Cs[r, c].Num == -1)
                        count++;
                }
            }
            return count;
        }
        void Search(int ri, int ci)
        {
            if (Cs[ri, ci].isOpen == true)
                return;
            Cs[ri, ci].isOpen = true;
            for (int r = ri - 1; r <= ri + 1; r++) 
            {
                for (int c = ci - 1; c <= ci + 1; c++) 
                {
                    if (r < 0 || r >= Dim || c < 0 || c >= Dim)
                        continue;
                    if (Cs[r, c].isOpen == false)
                    { 
                        if (Cs[r, c].Num != 0)
                        {
                            Cs[r, c].isOpen = true;
                            Cs[r, c].Text = (Cs[r, c].Num).ToString();
                        }
                        else if (Cs[r, c].Num == 0)
                            Search(r, c);
                        Cs[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }
        bool Win()
        {
            int count = 0;
            for (int ri = 0; ri < Dim; ri++)
                for (int ci = 0; ci < Dim; ci++)
                    if (Cs[ri, ci].isOpen)
                        count++;
            int n = Dim * Dim;
            if (n - NoMines == count) 
                return true;
            else
                return false;
        }
        private void Cell_Click(object sender, MouseEventArgs e)
        {
            Cell C = (Cell)sender;
            if (e.Button==MouseButtons.Right)
            {
                if (C.Flag == false)
                {
                    C.BackColor = Color.Red;
                    C.Flag = true;
                }
                else
                {
                    C.BackColor = Color.DarkGray;
                }
            }
            if (C.Flag == true)
            {
                return;
            }
            if (C.isOpen == true)
                return;
            if (C.Num == -1)
            {
                C.BackColor = Color.Black;
                Start.BackgroundImage = Image.FromFile(@"D:\D drive\OOP C#\Minesweeper\Minesweeper\Lost.jpg");
                MessageBox.Show("GAME OVER");
                timer1.Stop();
                t = 0;
                Board.Controls.Clear();
                Start.BackgroundImage = Image.FromFile(@"D:\D drive\OOP C#\Minesweeper\Minesweeper\Start.jpg");
            }
            else if (C.Num != 0) 
            {
                C.isOpen = true;
                C.Text = (C.Num).ToString();
                C.BackColor = Color.Gray;
            }
            else 
            {
                Search(C.ri, C.ci);
            }
            if (Win())
            {
                Start.BackgroundImage = Image.FromFile(@"D:\D drive\OOP C#\Minesweeper\Minesweeper\Win.jpg");
                MessageBox.Show("YOU WON");
                timer1.Stop();
                t = 0;
                Board.Controls.Clear();
                Start.BackgroundImage = Image.FromFile(@"D:\D drive\OOP C#\Minesweeper\Minesweeper\Start.jpg");
            }
        }
        
        private void Start_Click(object sender, EventArgs e)
        {
            if (Beginner.Checked)
            {
                Dim = 9;
                NoMines = 10;
            }
            if (Medium.Checked)
            {
                Dim = 16;
                NoMines = 40;
            }
            if (Expert.Checked)
            {
                Dim = 24;
                NoMines =99;
            }
            if (Dim == 0)
            {
                MessageBox.Show("Select Level!!!!");
                return;
            }
            LoadCell();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            StopWatch.Text = t.ToString();
            t++;
        }
    }
}
