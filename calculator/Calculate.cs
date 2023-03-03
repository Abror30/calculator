using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculate
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public string Func { get; set; }

        public Calculate(int num1, int num2, string operate)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Func = operate;
        }
        int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        int Remainder(int num1, int num2)
        {
            return (num1 % num2);
        }
        
    }
}
