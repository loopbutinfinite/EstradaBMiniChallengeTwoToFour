using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstradaBMiniChallenge_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstradaBMiniChallenge_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoNumberSumController : ControllerBase
    {
        private readonly TwoNumberSumServices _TwoNumberSumServices;

        public TwoNumberSumController(TwoNumberSumServices twoNumberSumServices)
        {
            _TwoNumberSumServices = twoNumberSumServices;
        }

        [HttpPost]
        [Route("Summation/{input1}/{input2}")]
        public string NumberSummationinator(string input1, string input2)
        {
            return _TwoNumberSumServices.SumOfTwoNumbers(input1, input2);
        }
    }
}