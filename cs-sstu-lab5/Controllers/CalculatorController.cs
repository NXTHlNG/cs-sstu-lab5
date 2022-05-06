using Microsoft.AspNetCore.Mvc;
using cs_sstu_lab5.Models;

namespace cs_sstu_lab5.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel calculatorModel)
        {
            if (!ModelState.IsValid) return View();

            switch(calculatorModel.Operation)
            {
                case CalculatorModel.OperationType.sum: 
                    calculatorModel.Result = calculatorModel.A + calculatorModel.B; break;
                case CalculatorModel.OperationType.substract: 
                    calculatorModel.Result = calculatorModel.A - calculatorModel.B; break;
                case CalculatorModel.OperationType.divide: 
                    calculatorModel.Result = calculatorModel.A / calculatorModel.B; break;
                case CalculatorModel.OperationType.multiply: 
                    calculatorModel.Result = calculatorModel.A * calculatorModel.B; break;
            }

            return View(calculatorModel);
        }
    }
}
