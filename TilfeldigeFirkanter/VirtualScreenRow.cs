using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeFirkanter
{
    internal class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;



        public VirtualScreenRow(int screenWidth) 
        {
            _cells = new VirtualScreenCell[screenWidth];

            for (int i = 0; i < screenWidth; i++)
            {
                _cells[i] = new VirtualScreenCell();
            }
            
            
        
        }

        public void AddBoxTopRow(int boxX, int boxWidth) 
        {
            _cells[boxX].AddUpperLeftCorner();
            int i = 0;
            for(i = 1; i < boxWidth - 1; i++) 
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + i].AddUpperRightCorner();
        }
        public void AddBoxBottomRow(int boxX, int boxWidth) 
        {
            _cells[boxX].AddLowerLeftCorner();
            int i = 0;
            for (i = 1; i < boxWidth - 1; i++)
            {
                _cells[boxX + i].AddHorizontal();
            }
            _cells[boxX + i].AddLowerRightCorner();
        }
        public void AddBoxMiddleRow(int boxX, int boxWidth) 
        {
            _cells[boxX].AddVertical();                
            _cells[boxX + boxWidth-1].AddVertical();
        }
        public void Show() 
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                Console.Write(_cells[i].GetCharacter());
            }
            Console.Write("\n");
        }
    }
}
