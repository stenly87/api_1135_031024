using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Model;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly Calculator calculator;
        private readonly Test test;

        public MathController(Calculator calculator, Test test)
        {
            this.calculator = calculator;
            this.test = test;
            // true т.к. время жизни scoped 
            bool equal = this.calculator == test.Calculator;
        }

        [HttpGet("КрутоеИмя")]
        public string Sum(int x, string y)
        {
            return calculator.Sum(x, y);
        }

        [HttpGet("НереальноКрутоеИмя")]
        public ActionResult<MultiplyResult> Multiply(int x, string y)
        {
            if (x == 0)
                return NotFound("Не найдено никаких проблем");
            return calculator.Multiply(x, y);
        }
    }
}
