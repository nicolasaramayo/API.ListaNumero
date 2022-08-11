using Microsoft.AspNetCore.Mvc;
using System;

namespace API.ListaNumero.Controllers
{
    public class ListNumber : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("basic/list")]
        public IActionResult GetBasic()
        {
            //var randomList = new random();
            var randomList = new Random();
            var numberRandon = randomList.Next(1,10);

            return Ok("" + numberRandon);
        }

        [HttpGet("jwt/list")]
        public IActionResult GetJwt()
        {
            //var randomList = new random();
            var randomList = new Random();
            var numberRandon = randomList.Next(1, 10);

            return Ok("" + numberRandon);
        }

    }
}
