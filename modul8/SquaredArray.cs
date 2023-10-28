using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8
{
    public class SquaredArray
    {
        private int[] array;

        public SquaredArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value * value;
            }
        }
    }

}
