using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Ladder
    {
        private int NumberStep;
        public void SetNumberStep(int NumberStep)
        {
            if (NumberStep > 0)
            {
                this.NumberStep = NumberStep; 
            } 
        }
        public int GetNumberStep()
            { return this.NumberStep; }
        public void PrintLadder(int NumberStep)
        {
            Console.WriteLine("***");
            for (int i = 0; i < NumberStep; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    { Console.WriteLine(new string(' ', (2 * i)) + "  *"); }
                    else if(j==1)
                    { Console.WriteLine(new string(' ', (2 * i)) + "  ***"); }
                }
            }
        }
        #region конструктор
        public Ladder()
        { NumberStep = 1; }
        public Ladder(int NumberStep)
        { this.NumberStep = NumberStep; }
        #endregion


        #region конструктор копирования
        public Ladder(Ladder other)
        {

            this.NumberStep = other.NumberStep;
        }
        #endregion
        ~Ladder() 
        {
            SetNumberStep(1);
        }
    }
}
