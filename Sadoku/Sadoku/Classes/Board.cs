using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sadoku.Classes
{
    internal class Board
    {
        List<List<Tile>> Tiles;
        public Board()
        {
            Tiles = new List<List<Tile>>();
        }

        public void GenerateBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                Tiles.Add(GetNewTilesColumn());
                for (int j = 0; j < 9; j++)
                {
                    Tiles.Last().Add(CreateNewTile(i, j));
                }
            }
        }
        public List<List<Tile>> GetTiles()
        {
            return Tiles;
        }
        private List<Tile> GetNewTilesColumn()
        {
            return new List<Tile>();
        }

        private Tile CreateNewTile(int x, int y)
        {
            int assignedBlock = 0;
            if (x >= 0 && x <= 2)
            {
                assignedBlock = YBlockCalc(y, 0);
            }
            else if (x >= 3 && x <= 5)
            {
                //3
                assignedBlock = YBlockCalc(y, 3);
            }
            else if (x >= 6 && x <= 8)
            {
                //6
                assignedBlock = YBlockCalc(y, 6);
            }
            return new Tile(assignedBlock, x, y);
        }

        private int YBlockCalc(int _y, int _index)
        {
            if (_y >= 0 && _y <= 2)
            {
                return _index + 1;
            }
            else if (_y >= 3 && _y <= 5)
            {
                return _index + 2;
            }
            else
            {
                return _index + 3;
            }
        }

        public void CheckValidCells()
        {
            CheckRows();
            CheckCols();
            CheckBoxes();
        }

        private void CheckCols()
        {
            for (int i = 0; i <= 9; i++) {
                
            }
        }
        private void CheckRows()
        {

        }

        private void CheckBoxes()
        {

        }
    }
}
