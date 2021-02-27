using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrojanjeReciWebAPI.Services;

namespace BrojanjeReciWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        private readonly ILogger<TextController> _logger;
        private readonly ITextProcessingService _textProcService;

        public TextController(ILogger<TextController> logger, ITextProcessingService textProcService)
        {
            _logger = logger;
            _textProcService = textProcService;
        }

        [HttpPost("CountWords")]
        public ActionResult<int> CountWords([FromBody] TextDTO textDto)
        {
            _logger.LogInformation("CountingWords => STARTED");
            int count = 0;
            if (textDto.Text != null)
            {
                count = _textProcService.CountWords(textDto.Text);
            }

            _logger.LogInformation("CountingWords => ENDED");
            return Ok(count);
        }




    }
}
