using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace SolveSudoku
{
    public partial class SolveSudoku : Form
    {
        public SolveSudoku()
        {
            InitializeComponent();
        }

        private void SolveSudoku_Load(object sender, EventArgs e)
        {

        }


        int[,] S = new int[9, 9];
        
        private void GetData()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    S[i, j] = 0;

            #region Lấy Dữ Liệu Dòng Thứ 0
            if (tbx00.Text != "")
            {
                S[0, 0] = Convert.ToInt32(tbx00.Text);
                tbx00.ReadOnly = true;
            }

            if (tbx01.Text != "")
            {
                S[0,1] = Convert.ToInt32(tbx01.Text);
                tbx01.ReadOnly = true;
            }

            if (tbx02.Text != "")
            {
                S[0,2] = Convert.ToInt32(tbx02.Text);
                tbx02.ReadOnly = true;
            }

            if (tbx03.Text != "")
            {
                S[0,3] = Convert.ToInt32(tbx03.Text);
                tbx03.ReadOnly = true;
            }

            if (tbx04.Text != "")
            {
                S[0,4] = Convert.ToInt32(tbx04.Text);
                tbx04.ReadOnly = true;
            }

            if (tbx05.Text != "")
            {
                S[0,5] = Convert.ToInt32(tbx05.Text);
                tbx05.ReadOnly = true;
            }

            if (tbx06.Text != "")
            {
                S[0,6] = Convert.ToInt32(tbx06.Text);
                tbx06.ReadOnly = true;
            }

            if (tbx07.Text != "")
            {
                S[0,7] = Convert.ToInt32(tbx07.Text);
                tbx07.ReadOnly = true;
            }

            if (tbx08.Text != "")
            {
                S[0,8] = Convert.ToInt32(tbx08.Text);
                tbx08.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 1
            if (tbx10.Text != "")
            {
                S[1,0] = Convert.ToInt32(tbx10.Text);
                tbx10.ReadOnly = true;
            }

            if (tbx11.Text != "")
            {
                S[1,1] = Convert.ToInt32(tbx11.Text);
                tbx11.ReadOnly = true;
            }

            if (tbx12.Text != "")
            {
                S[1,2] = Convert.ToInt32(tbx12.Text);
                tbx12.ReadOnly = true;
            }

            if (tbx13.Text != "")
            {
                S[1,3] = Convert.ToInt32(tbx13.Text);
                tbx13.ReadOnly = true;
            }

            if (tbx14.Text != "")
            {
                S[1,4] = Convert.ToInt32(tbx14.Text);
                tbx14.ReadOnly = true;
            }

            if (tbx15.Text != "")
            {
                S[1,5] = Convert.ToInt32(tbx15.Text);
                tbx15.ReadOnly = true;
            }

            if (tbx16.Text != "")
            {
                S[1,6] = Convert.ToInt32(tbx16.Text);
                tbx16.ReadOnly = true;
            }

            if (tbx17.Text != "")
            {
                S[1,7] = Convert.ToInt32(tbx17.Text);
                tbx17.ReadOnly = true;
            }

            if (tbx18.Text != "")
            {
                S[1,8] = Convert.ToInt32(tbx18.Text);
                tbx18.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 2
            if (tbx20.Text != "")
            {
                S[2,0] = Convert.ToInt32(tbx20.Text);
                tbx20.ReadOnly = true;
            }

            if (tbx21.Text != "")
            {
                S[2,1] = Convert.ToInt32(tbx21.Text);
                tbx21.ReadOnly = true;
            }

            if (tbx22.Text != "")
            {
                S[2,2] = Convert.ToInt32(tbx22.Text);
                tbx22.ReadOnly = true;
            }

            if (tbx23.Text != "")
            {
                S[2,3] = Convert.ToInt32(tbx23.Text);
                tbx23.ReadOnly = true;
            }

            if (tbx24.Text != "")
            {
                S[2,4] = Convert.ToInt32(tbx24.Text);
                tbx24.ReadOnly = true;
            }

            if (tbx25.Text != "")
            {
                S[2,5] = Convert.ToInt32(tbx25.Text);
                tbx25.ReadOnly = true;
            }

            if (tbx26.Text != "")
            {
                S[2,6] = Convert.ToInt32(tbx26.Text);
                tbx26.ReadOnly = true;
            }

            if (tbx27.Text != "")
            {
                S[2,7] = Convert.ToInt32(tbx27.Text);
                tbx27.ReadOnly = true;
            }

            if (tbx28.Text != "")
            {
                S[2,8] = Convert.ToInt32(tbx28.Text);
                tbx28.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 3
            if (tbx30.Text != "")
            {
                S[3,0] = Convert.ToInt32(tbx30.Text);
                tbx30.ReadOnly = true;
            }

            if (tbx31.Text != "")
            {
                S[3,1] = Convert.ToInt32(tbx31.Text);
                tbx31.ReadOnly = true;
            }

            if (tbx32.Text != "")
            {
                S[3,2] = Convert.ToInt32(tbx32.Text);
                tbx32.ReadOnly = true;
            }

            if (tbx33.Text != "")
            {
                S[3,3] = Convert.ToInt32(tbx33.Text);
                tbx33.ReadOnly = true;
            }

            if (tbx34.Text != "")
            {
                S[3,4] = Convert.ToInt32(tbx34.Text);
                tbx34.ReadOnly = true;
            }

            if (tbx35.Text != "")
            {
                S[3,5] = Convert.ToInt32(tbx35.Text);
                tbx35.ReadOnly = true;
            }

            if (tbx36.Text != "")
            {
                S[3,6] = Convert.ToInt32(tbx36.Text);
                tbx36.ReadOnly = true;
            }

            if (tbx37.Text != "")
            {
                S[3,7] = Convert.ToInt32(tbx37.Text);
                tbx37.ReadOnly = true;
            }

            if (tbx38.Text != "")
            {
                S[3,8] = Convert.ToInt32(tbx38.Text);
                tbx38.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 4
            if (tbx40.Text != "")
            {
                S[4,0] = Convert.ToInt32(tbx40.Text);
                tbx40.ReadOnly = true;
            }

            if (tbx41.Text != "")
            {
                S[4,1] = Convert.ToInt32(tbx41.Text);
                tbx41.ReadOnly = true;
            }

            if (tbx42.Text != "")
            {
                S[4,2] = Convert.ToInt32(tbx42.Text);
                tbx42.ReadOnly = true;
            }

            if (tbx43.Text != "")
            {
                S[4,3] = Convert.ToInt32(tbx43.Text);
                tbx43.ReadOnly = true;
            }

            if (tbx44.Text != "")
            {
                S[4,4] = Convert.ToInt32(tbx44.Text);
                tbx44.ReadOnly = true;
            }

            if (tbx45.Text != "")
            {
                S[4,5] = Convert.ToInt32(tbx45.Text);
                tbx45.ReadOnly = true;
            }

            if (tbx46.Text != "")
            {
                S[4,6] = Convert.ToInt32(tbx46.Text);
                tbx46.ReadOnly = true;
            }

            if (tbx47.Text != "")
            {
                S[4,7] = Convert.ToInt32(tbx47.Text);
                tbx47.ReadOnly = true;
            }

            if (tbx48.Text != "")
            {
                S[4,8] = Convert.ToInt32(tbx48.Text);
                tbx48.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 5
            if (tbx50.Text != "")
            {
                S[5,0] = Convert.ToInt32(tbx50.Text);
                tbx50.ReadOnly = true;
            }

            if (tbx51.Text != "")
            {
                S[5,1] = Convert.ToInt32(tbx51.Text);
                tbx51.ReadOnly = true;
            }

            if (tbx52.Text != "")
            {
                S[5,2] = Convert.ToInt32(tbx52.Text);
                tbx52.ReadOnly = true;
            }

            if (tbx53.Text != "")
            {
                S[5,3] = Convert.ToInt32(tbx53.Text);
                tbx53.ReadOnly = true;
            }

            if (tbx54.Text != "")
            {
                S[5,4] = Convert.ToInt32(tbx54.Text);
                tbx54.ReadOnly = true;
            }

            if (tbx55.Text != "")
            {
                S[5,5] = Convert.ToInt32(tbx55.Text);
                tbx55.ReadOnly = true;
            }

            if (tbx56.Text != "")
            {
                S[5,6] = Convert.ToInt32(tbx56.Text);
                tbx56.ReadOnly = true;
            }

            if (tbx57.Text != "")
            {
                S[5,7] = Convert.ToInt32(tbx57.Text);
                tbx57.ReadOnly = true;
            }

            if (tbx58.Text != "")
            {
                S[5,8] = Convert.ToInt32(tbx58.Text);
                tbx58.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 6
            if (tbx60.Text != "")
            {
                S[6,0] = Convert.ToInt32(tbx60.Text);
                tbx60.ReadOnly = true;
            }

            if (tbx61.Text != "")
            {
                S[6,1] = Convert.ToInt32(tbx61.Text);
                tbx61.ReadOnly = true;
            }

            if (tbx62.Text != "")
            {
                S[6,2] = Convert.ToInt32(tbx62.Text);
                tbx62.ReadOnly = true;
            }

            if (tbx63.Text != "")
            {
                S[6,3] = Convert.ToInt32(tbx63.Text);
                tbx63.ReadOnly = true;
            }

            if (tbx64.Text != "")
            {
                S[6,4] = Convert.ToInt32(tbx64.Text);
                tbx64.ReadOnly = true;
            }

            if (tbx65.Text != "")
            {
                S[6,5] = Convert.ToInt32(tbx65.Text);
                tbx65.ReadOnly = true;
            }

            if (tbx66.Text != "")
            {
                S[6,6] = Convert.ToInt32(tbx66.Text);
                tbx66.ReadOnly = true;
            }

            if (tbx67.Text != "")
            {
                S[6,7] = Convert.ToInt32(tbx67.Text);
                tbx67.ReadOnly = true;
            }

            if (tbx68.Text != "")
            {
                S[6,8] = Convert.ToInt32(tbx68.Text);
                tbx68.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 7
            if (tbx70.Text != "")
            {
                S[7,0] = Convert.ToInt32(tbx70.Text);
                tbx70.ReadOnly = true;
            }

            if (tbx71.Text != "")
            {
                S[7,1] = Convert.ToInt32(tbx71.Text);
                tbx71.ReadOnly = true;
            }

            if (tbx72.Text != "")
            {
                S[7,2] = Convert.ToInt32(tbx72.Text);
                tbx72.ReadOnly = true;
            }

            if (tbx73.Text != "")
            {
                S[7,3] = Convert.ToInt32(tbx73.Text);
                tbx73.ReadOnly = true;
            }

            if (tbx74.Text != "")
            {
                S[7,4] = Convert.ToInt32(tbx74.Text);
                tbx74.ReadOnly = true;
            }

            if (tbx75.Text != "")
            {
                S[7,5] = Convert.ToInt32(tbx75.Text);
                tbx75.ReadOnly = true;
            }

            if (tbx76.Text != "")
            {
                S[7,6] = Convert.ToInt32(tbx76.Text);
                tbx76.ReadOnly = true;
            }

            if (tbx77.Text != "")
            {
                S[7,7] = Convert.ToInt32(tbx77.Text);
                tbx77.ReadOnly = true;
            }

            if (tbx78.Text != "")
            {
                S[7,8] = Convert.ToInt32(tbx78.Text);
                tbx78.ReadOnly = true;
            }
            #endregion

            #region Lấy Dữ Liệu Dòng Thứ 8
            if (tbx80.Text != "")
            {
                S[8,0] = Convert.ToInt32(tbx80.Text);
                tbx80.ReadOnly = true;
            }

            if (tbx81.Text != "")
            {
                S[8,1] = Convert.ToInt32(tbx81.Text);
                tbx81.ReadOnly = true;
            }

            if (tbx82.Text != "")
            {
                S[8,2] = Convert.ToInt32(tbx82.Text);
                tbx82.ReadOnly = true;
            }

            if (tbx83.Text != "")
            {
                S[8,3] = Convert.ToInt32(tbx83.Text);
                tbx83.ReadOnly = true;
            }

            if (tbx84.Text != "")
            {
                S[8,4] = Convert.ToInt32(tbx84.Text);
                tbx84.ReadOnly = true;
            }

            if (tbx85.Text != "")
            {
                S[8,5] = Convert.ToInt32(tbx85.Text);
                tbx85.ReadOnly = true;
            }

            if (tbx86.Text != "")
            {
                S[8,6] = Convert.ToInt32(tbx86.Text);
                tbx86.ReadOnly = true;
            }

            if (tbx87.Text != "")
            {
                S[8,7] = Convert.ToInt32(tbx87.Text);
                tbx87.ReadOnly = true;
            }

            if (tbx88.Text != "")
            {
                S[8,8] = Convert.ToInt32(tbx88.Text);
                tbx88.ReadOnly = true;
            }
            #endregion
        }

        private void printSolution()
        {
            #region In Dữ Liệu Ra Dòng Thứ 0
            tbx00.Text = S[0, 0].ToString();
            tbx01.Text = S[0, 1].ToString();
            tbx02.Text = S[0, 2].ToString();
            tbx03.Text = S[0, 3].ToString();
            tbx04.Text = S[0, 4].ToString();
            tbx05.Text = S[0, 5].ToString();
            tbx06.Text = S[0, 6].ToString();
            tbx07.Text = S[0, 7].ToString();
            tbx08.Text = S[0, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 1
            tbx10.Text = S[1, 0].ToString();
            tbx11.Text = S[1, 1].ToString();
            tbx12.Text = S[1, 2].ToString();
            tbx13.Text = S[1, 3].ToString();
            tbx14.Text = S[1, 4].ToString();
            tbx15.Text = S[1, 5].ToString();
            tbx16.Text = S[1, 6].ToString();
            tbx17.Text = S[1, 7].ToString();
            tbx18.Text = S[1, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 2
            tbx20.Text = S[2, 0].ToString();
            tbx21.Text = S[2, 1].ToString();
            tbx22.Text = S[2, 2].ToString();
            tbx23.Text = S[2, 3].ToString();
            tbx24.Text = S[2, 4].ToString();
            tbx25.Text = S[2, 5].ToString();
            tbx26.Text = S[2, 6].ToString();
            tbx27.Text = S[2, 7].ToString();
            tbx28.Text = S[2, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 3
            tbx30.Text = S[3, 0].ToString();
            tbx31.Text = S[3, 1].ToString();
            tbx32.Text = S[3, 2].ToString();
            tbx33.Text = S[3, 3].ToString();
            tbx34.Text = S[3, 4].ToString();
            tbx35.Text = S[3, 5].ToString();
            tbx36.Text = S[3, 6].ToString();
            tbx37.Text = S[3, 7].ToString();
            tbx38.Text = S[3, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 4
            tbx40.Text = S[4, 0].ToString();
            tbx41.Text = S[4, 1].ToString();
            tbx42.Text = S[4, 2].ToString();
            tbx43.Text = S[4, 3].ToString();
            tbx44.Text = S[4, 4].ToString();
            tbx45.Text = S[4, 5].ToString();
            tbx46.Text = S[4, 6].ToString();
            tbx47.Text = S[4, 7].ToString();
            tbx48.Text = S[4, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 5
            tbx50.Text = S[5, 0].ToString();
            tbx51.Text = S[5, 1].ToString();
            tbx52.Text = S[5, 2].ToString();
            tbx53.Text = S[5, 3].ToString();
            tbx54.Text = S[5, 4].ToString();
            tbx55.Text = S[5, 5].ToString();
            tbx56.Text = S[5, 6].ToString();
            tbx57.Text = S[5, 7].ToString();
            tbx58.Text = S[5, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 6
            tbx60.Text = S[6, 0].ToString();
            tbx61.Text = S[6, 1].ToString();
            tbx62.Text = S[6, 2].ToString();
            tbx63.Text = S[6, 3].ToString();
            tbx64.Text = S[6, 4].ToString();
            tbx65.Text = S[6, 5].ToString();
            tbx66.Text = S[6, 6].ToString();
            tbx67.Text = S[6, 7].ToString();
            tbx68.Text = S[6, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 7
            tbx70.Text = S[7, 0].ToString();
            tbx71.Text = S[7, 1].ToString();
            tbx72.Text = S[7, 2].ToString();
            tbx73.Text = S[7, 3].ToString();
            tbx74.Text = S[7, 4].ToString();
            tbx75.Text = S[7, 5].ToString();
            tbx76.Text = S[7, 6].ToString();
            tbx77.Text = S[7, 7].ToString();
            tbx78.Text = S[7, 8].ToString();
            #endregion

            #region In Dữ Liệu Ra Dòng Thứ 0
            tbx80.Text = S[8, 0].ToString();
            tbx81.Text = S[8, 1].ToString();
            tbx82.Text = S[8, 2].ToString();
            tbx83.Text = S[8, 3].ToString();
            tbx84.Text = S[8, 4].ToString();
            tbx85.Text = S[8, 5].ToString();
            tbx86.Text = S[8, 6].ToString();
            tbx87.Text = S[8, 7].ToString();
            tbx88.Text = S[8, 8].ToString();
            #endregion
        }

        int feasible(int x, int y, int k)
        {
            int i = 0, j = 0;
            for (i = 0; i < 9; i++)
            {
                if (S[x,i] == k) return 0;
            }
            for (i = 0; i < 9; i++)
            {
                if (S[i,y] == k) return 0;
            }
            int a = x / 3, b = y / 3;
            for (i = 3 * a; i < 3 * a + 3; i++)
            {
                for (j = 3 * b; j < 3 * b + 3; j++)
                {
                    if (S[i,j] == k) return 0;
                }
            }
            return 1;

        }
        
        void solve_sudoku(int x, int y)
        {
            if (y == 9)
            {
                if (x == 8)
                {
                    printSolution();
                    return;
                }
                else
                {
                    solve_sudoku(x + 1, 0);
                }
            }
            else if (S[x,y] == 0)
            {
                int k = 0;
                for (k = 1; k <= 9; k++)
                {
                    if (feasible(x, y, k) == 1)
                    {
                        S[x,y] = k;
                        solve_sudoku(x, y + 1);
                        S[x,y] = 0;
                    }
                }
            }
            else
            {
                solve_sudoku(x, y + 1);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            GetData();
            solve_sudoku(0, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbx00.Text = "";
            tbx01.Text = "";
            tbx02.Text = "";
            tbx03.Text = "";
            tbx04.Text = "";
            tbx05.Text = "";
            tbx06.Text = "";
            tbx07.Text = "";
            tbx08.Text = "";
            tbx10.Text = "";
            tbx11.Text = "";
            tbx12.Text = "";
            tbx13.Text = "";
            tbx14.Text = "";
            tbx15.Text = "";
            tbx16.Text = "";
            tbx17.Text = "";
            tbx18.Text = "";
            tbx20.Text = "";
            tbx21.Text = "";
            tbx22.Text = "";
            tbx23.Text = "";
            tbx24.Text = "";
            tbx25.Text = "";
            tbx26.Text = "";
            tbx27.Text = "";
            tbx28.Text = "";
            tbx30.Text = "";
            tbx31.Text = "";
            tbx32.Text = "";
            tbx33.Text = "";
            tbx34.Text = "";
            tbx35.Text = "";
            tbx36.Text = "";
            tbx37.Text = "";
            tbx38.Text = "";
            tbx40.Text = "";
            tbx41.Text = "";
            tbx42.Text = "";
            tbx43.Text = "";
            tbx44.Text = "";
            tbx45.Text = "";
            tbx46.Text = "";
            tbx47.Text = "";
            tbx48.Text = "";
            tbx50.Text = "";
            tbx51.Text = "";
            tbx52.Text = "";
            tbx53.Text = "";
            tbx54.Text = "";
            tbx55.Text = "";
            tbx56.Text = "";
            tbx57.Text = "";
            tbx58.Text = "";
            tbx60.Text = "";
            tbx61.Text = "";
            tbx62.Text = "";
            tbx63.Text = "";
            tbx64.Text = "";
            tbx65.Text = "";
            tbx66.Text = "";
            tbx67.Text = "";
            tbx68.Text = "";
            tbx70.Text = "";
            tbx71.Text = "";
            tbx72.Text = "";
            tbx73.Text = "";
            tbx74.Text = "";
            tbx75.Text = "";
            tbx76.Text = "";
            tbx77.Text = "";
            tbx78.Text = "";
            tbx80.Text = "";
            tbx81.Text = "";
            tbx82.Text = "";
            tbx83.Text = "";
            tbx84.Text = "";
            tbx85.Text = "";
            tbx86.Text = "";
            tbx87.Text = "";
            tbx88.Text = "";
        }

    }
}
