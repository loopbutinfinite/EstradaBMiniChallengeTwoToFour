using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallenge_2.Services
{
    public class TwoNumberSumServices
    {
        public string TwoNumberSummation(double userNum1, double userNum2)
        {
            return $"The sum of both {userNum1} and {userNum2} is {userNum1 + userNum2}.";
        }
    }
}