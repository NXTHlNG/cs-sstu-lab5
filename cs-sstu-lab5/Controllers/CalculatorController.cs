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
        public IActionResult Index(CalculatorModel calculatorModel)
        {
            double a, b;
            
            if (double.TryParse(calculatorModel.A, out a) && double.TryParse(calculatorModel.B, out b))
            {
                switch (calculatorModel.Operation)
                {
                    case CalculatorModel.OperationType.sum:
                        calculatorModel.Result = (a + b).ToString(); break;

                    case CalculatorModel.OperationType.substract:
                        calculatorModel.Result = (a - b).ToString(); break;

                    case CalculatorModel.OperationType.divide:
                        if (b == 0) calculatorModel.Result = "Divide by zero";
                        else calculatorModel.Result = (a / b).ToString(); break;

                    case CalculatorModel.OperationType.multiply:
                        calculatorModel.Result = (a * b).ToString(); break;
                }
            }
            else
            {
                calculatorModel.Result = "Not a number";
            }

            return View(calculatorModel);
        }

        [HttpPost]
        public string Calculate([FromBody] CalculatorModel calculatorModel)
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
