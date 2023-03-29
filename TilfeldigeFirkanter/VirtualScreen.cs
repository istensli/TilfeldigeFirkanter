using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeFirkanter
{
    internal class VirtualScreen
    {
        private VirtualScreenRow[] _rows;

        public VirtualScreen(int width, int height) {
            _rows = new VirtualScreenRow[height];
            for (int i = 0; i < height; i++)
            {
                _rows[i] = new VirtualScreenRow(width);

            }
        }
        public void Add(Box box) 
        {
            _rows[box.Y].AddBoxTopRow(box.X, box.Width);
            for (int i = box.StartY+1; i < box.EndY; i++) //box.EndY-1
            {
                _rows[i].AddBoxMiddleRow(box.X, box.Width);
            }
           _rows[box.EndY].AddBoxBottomRow(box.X, box.Width); //her kan indeks havne utenfor arrayen..

        }
        public void Show() 
        {
            foreach (var row in _rows)
            {
                row.Show();
            }

        }
    }
}
