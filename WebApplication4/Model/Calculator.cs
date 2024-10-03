using WebApplication4.Controllers;

namespace WebApplication4.Model
{
    public class Calculator
    {
        static int i = 0;

        public Calculator()
        {
            i++;
        }

        public string Sum(int x, string y)
        {
            Thread.Sleep(1000);
            return string.Join("", 
                Enumerable.Range(1, x).Select(i => y));
        }

        internal MultiplyResult Multiply(int x, string y)
        {
            return new MultiplyResult
            {
                X = x,
                Y = y,
                Result  = "денег на разработку не хватило"
            };
        }
    }


    public class Test
    {
        public Test(Calculator calculator)
        {
            Calculator = calculator;
        }

        public Calculator Calculator { get; }
    }
}
