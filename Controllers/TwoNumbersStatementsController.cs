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
    public class TwoNumbersStatementsController : ControllerBase
    {
        private readonly TwoNumbersStatementsServices _TwoNumersStatementsServices;

        public TwoNumbersStatementsController(TwoNumbersStatementsServices twoNumbersStatementsServices)
        {
            _TwoNumersStatementsServices = twoNumbersStatementsServices;
        }

        [HttpPost]
        [Route("Response/{num1}/{num2}")]
        public string StatementResponses(double num1, double num2)
        {
            return _TwoNumersStatementsServices.ReturnStatementResponses(num1, num2);
        }
    }
}