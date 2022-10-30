using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        private int a;
        private int b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }
        public int Sosanh(int a, int b)
        {
            int r;
            //r = 1 : a>b , a>1 ,a>0
            //r = 0 : a<b 
            if(a>b || a>1 || a>0)
            {
                r = 1;
            }
            else
            {
                r = 0;
            }
            return r;
        }
    }
}
