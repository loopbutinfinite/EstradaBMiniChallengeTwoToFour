using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallenge_2.Services
{
    public class TwoNumbersStatementsServices
    {
        public string ReturnStatementResponses(double num1, double num2)
        {
            if(num1 > num2)
            {
                return $"{num1} is greater than {num2}. {num2} is less than {num1}.";
            }
            else if (num1 < num2)
            {
                return $"{num1} is less than {num2}. {num2} is greater than {num1}.";
            }
            else
            {
                return $"{num1} is equal to {num2}. {num2} is equal to {num1}.";
            }
        }
    }
}