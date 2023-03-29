using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfeldigeFirkanter
{
    internal class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }

        public VirtualScreenCell()
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }

        public char GetCharacter()
        {
            if (!Up && !Down && !Left && !Right) return ' ';
            else if (Up && !Down && !Left && !Right) return '╹';
            else if (!Up && Down && !Left && !Right) return '╻';
            else if (Up && Down && !Left && !Right) return '│';
            else if (!Up && !Down && !Left && Right) return '╺';
            else if (!Up && !Down && Left && !Right) return '╸';
            else if (!Up && !Down && Left && Right) return '─';
            else if (!Up && Down && !Left && Right) return '┌';
            else if (!Up && Down && Left && !Right) return '┐';
            else if (Up && !Down && !Left && Right) return '└';
            else if (Up && !Down && Left && !Right) return '┘';
            else if (Up && Down && Left && Right) return '┼';
            else if (!Up && Down && Left && Right) return '┬';
            else if (Up && Down && Left && !Right) return '┤';
            else if (Up && Down && !Left && Right) return '├';
            else if (Up && !Down && Left && Right) return '┴';
            else if (!Up && Down && Left && Right) return '┬';
            else return ' ';


        }

        public void AddHorizontal() 
        {
            Left = true;
            Right = true;
        }
        public void AddVertical() 
        {
            Up = true;
            Down = true;
        }
        public void AddLowerLeftCorner() 
        {
            Right = true;
            Up = true;

        }
        public void AddUpperLeftCorner() 
        {
            Down = true;
            Right = true;
            
        }
        public void AddUpperRightCorner() 
        {
            Down = true;
            Left = true;

        }
        public void AddLowerRightCorner() 
        {
            Left = true;
            Up = true;

        }
    }
}
