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
        [Route("Summation/{userNum1}/{userNum2}")]
        public string NumberSummationinator(double userNum1, double userNum2)
        {
            return _TwoNumberSumServices.TwoNumberSummation(userNum1, userNum2);
        }
    }
}