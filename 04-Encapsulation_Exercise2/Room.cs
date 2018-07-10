using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise2
{
    public class Room
    {
        private int _length;

        public int Length
        {
            get => _length;
            private set
            {
                if (value < 6 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Length must be between 6 and 30 feet.");
                }
                else
                {
                    _length = value;
                }
            }
        }

        private int _width;

        public int Width
        {
            get => _width;
            private set
            {
                if (value < 6 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Width must be between 6 and 30 feet.");
                }
                else
                {
                    _width = value;
                }
            }
        }

        private int _height;

        public int Height
        {
            get => _height;
            private set
            {
                if (value < 10 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Height must be between 10 and 12 feet.");
                }
                else
                {
                    _height = value;
                }
            }
        }

        public Room(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int CalculateSurfaceArea()
        {
            var SurfaceArea =
                Length * Height;
            return SurfaceArea;
        }
    }
}
