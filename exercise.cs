using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Shooter_Game
{
    internal class exercise
    {
       // private const int numberSize = 2;
       //public int[] numbers = new int[numberSize];

        public int num1, num2;

        public bool add(int x, int y, int z)
        {
            if ((x + y) == z) { return true; }
            else { return false; }
        }

        public void randNumbers()
        {
            num1 = new Random().Next(1,9);
            num2 = new Random().Next(1, 9);
        }

        

    }
}
