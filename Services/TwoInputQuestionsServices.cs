using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallenge_2.Services
{
    public class TwoInputQuestionsServices
    {
        public string ReturnResponse(string name, string time)
        {
            return $"Ok, so your name is {name} and you woke up today at {time}. Nice to meet you!";
        }
    }
}