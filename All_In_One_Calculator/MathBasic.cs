using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_In_One_Calculator
{
    class MathBasic
    {
        private double n1, n2;

        public void setN1(double n1)
        {
            this.n1 = n1;
        }

        public void setN2(double n2) 
        {
            this.n2 = n2;
        }

        public void clear()
        {
            this.n1 = 0;
            this.n2 = 0;
        }

        public double add() 
        {
            return this.n1 + this.n2;
        }

        public double sub()
        {
            return this.n1 - this.n2;
        }

        public double div()
        {
            return this.n1 / this.n2;
        }

        public double mul()
        {
            return this.n1 * this.n2;
        }
    }
}
