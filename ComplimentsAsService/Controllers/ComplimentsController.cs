using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplimentsAsService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplimentsAsService.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ComplimentsController : Controller
    {
        
        [HttpGet("/hello")]
        public IActionResult Hello()
        {
            
            return CreateResponse(
                $"Hello, world",
                "-Everyone"
                );
        }

        [HttpGet("hello/{name}.{format?}")]
        public IActionResult HelloName(string name, string format)
        {
            return CreateResponse(
                $"Hello, {name}",
                "",
                format
                );
        }

        [HttpGet("cute/{name}/{from}.{format?}")]
        public IActionResult CuteNameFrom(string name, string from, string format = "")
        {
            return CreateResponse(
                $"Heeey, {name}, you're cute!",
                $"-{from}",
                format
                );
            
        }

        private IActionResult CreateResponse(string message, string subtitle = "", string format = "")
        {
            ComplimentModel compliment = new ComplimentModel
            {
                Message = message,
                Subtitle = subtitle,
            };
            if (format == "json")
            {
                return Ok(compliment);
            }
            else
            {
                return View("index", compliment);
                //return Content($"{message} {subtitle}");
            }
        }
    }
}