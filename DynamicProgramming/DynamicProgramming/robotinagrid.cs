using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class robotinagrid
    {
        public List<(int, int)> RobotInGrid(bool [,] Grid)
        {
            List<(int row, int col)> paths = new List<(int, int)>();
            bool[,] check = new bool[Grid.GetLength(0), Grid.GetLength(1)];
            if (getPaths(Grid, Grid.GetLength(0) - 1, Grid.GetLength(1) - 1, paths, check)){
                return paths;
            }
            return null;
        }

        public bool getPaths(bool[,] Grid, int row, int col, List<(int, int)> paths, bool[,] check)
        {
            if (row < 0 || col < 0 || Grid[row, col] == false)
            {
                return false;
            }
            if (check[row, col] == true)
            {
                return false;
            }
            if (getPaths(Grid, row - 1, col, paths, check) || getPaths(Grid, row, col - 1, paths, check) || (row == 0 && col == 0))
            {
                paths.Add((row, col));
                return true;
            }
            check[row, col] = true;
            return false;
        }
    }
}
