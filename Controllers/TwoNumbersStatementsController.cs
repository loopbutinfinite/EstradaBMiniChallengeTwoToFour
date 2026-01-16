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

        [HttpGet]
        [Route("Response/{input1}/{input2}")]
        public string StatementResponses(string input1, string input2)
        {
            return _TwoNumersStatementsServices.ReturnStatements(input1, input2);
        }
    }
}