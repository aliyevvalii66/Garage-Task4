using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Max
    {
        public int MaxNumber(int number1, int number2, int number3)
        {
            int maxNumber = number1;
            if (maxNumber < number2)
            {
                maxNumber = number2;
            }
            if(number3> maxNumber)
            {
                maxNumber = number3;
            }
            return maxNumber;
        }
        public int MaxNumber(int number1, int number2, int number3, int number4)
        {
            int max = MaxNumber(number1, number2, number3);
            return max > number4 ? max : number4;
        }
        public int MaxNumber(int number1, int number2, int number3, int number4,int number5)
        {
            int max = MaxNumber(number1, number2, number3,number4);
            return max > number5 ? max : number5;
        }
    }
}
