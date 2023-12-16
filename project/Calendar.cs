using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{

    internal class Calendar
    {
        private int num1;
        private int num2;

        public Calendar(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Add(int num1, int num2)
        {
            int n1 = (num1); int 
                n2 = (num2); 
           int answer = n1 + n2;
            return answer;

        }
        public int Substract(int num1, int num2)
        {
            int n1 = (num1); int
                n2 = (num2);
            if(num1>num2)
            {
                int answer = n1 - n2;
                Math.Abs(answer);
                return answer;

            }
            int ans = n2-n1;
            
            return ans;


        }
        public int multiply(int num1, int num2)
        {
            int n1 = (num1); int
                n2 = (num2);
            int answer = n1 * n2;
            
            return answer;

        }
        public int Divide(int num1, int num2)
        {
            int n1 = (num1); int
                n2 = (num2);
            int answer = n1 / n2;

            return answer;

        }

    }
}
