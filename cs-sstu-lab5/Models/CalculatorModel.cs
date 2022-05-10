using System.ComponentModel.DataAnnotations;

namespace cs_sstu_lab5.Models
{
    public class CalculatorModel
    {
        [Display(Name = "First Number")]
        public string A { get; set; }
        [Display(Name = "Second Number")]
        public string B { get; set; }
        public OperationType Operation { get; set; }
        public string Result { get; set; }

        public enum OperationType
        {
            sum,
            substract,
            divide,
            multiply
        }
    }
}
