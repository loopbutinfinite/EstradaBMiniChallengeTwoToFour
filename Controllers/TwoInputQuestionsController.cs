using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstradaBMiniChallenge_2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EstradaBMiniChallenge_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoInputQuestionsController : ControllerBase
    {
        private readonly TwoInputQuestionsServices _TwoInputQuestionsServices;

        public TwoInputQuestionsController(TwoInputQuestionsServices twoInputQuestionsServices)
        {
            _TwoInputQuestionsServices = twoInputQuestionsServices;
        }

        [HttpPost]
        [Route("QuestionsResponse/{name}/{time}")]
        public string ResponseToQuestionsinator(string name, string time)
        {
            return _TwoInputQuestionsServices.ReturnResponse(name, time);
        }
    }
}