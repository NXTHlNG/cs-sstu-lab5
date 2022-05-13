using Microsoft.AspNetCore.Mvc;
using cs_sstu_lab5.Models;

namespace cs_sstu_lab5.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("_Calculator");
        }

        [HttpPost]
        public string Calculate(CalculatorModel calculatorModel)
        {
            double a, b, result = 0;

            if (double.TryParse(calculatorModel.A, out a) && double.TryParse(calculatorModel.B, out b))
            {
                switch (calculatorModel.Operation)
                {
                    case CalculatorModel.OperationType.sum:
                        result = a + b; break;

                    case CalculatorModel.OperationType.substract:
                        result = a - b; break;

                    case CalculatorModel.OperationType.divide:
                        if (b == 0) result = double.NaN;
                        else result = a / b; break;

                    case CalculatorModel.OperationType.multiply:
                        result = a * b; break;
                }
            }
            else
            {
                result = double.NaN;
            }

            return result.ToString();
        }
    }
}
