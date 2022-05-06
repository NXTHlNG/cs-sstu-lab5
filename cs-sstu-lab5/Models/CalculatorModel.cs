using System.ComponentModel.DataAnnotations;

namespace cs_sstu_lab5.Models
{
    public class CalculatorModel
    {
        [Display(Name = "First Number")]
        public double A { get; set; }
        [Display(Name = "Second Number")]
        public double B { get; set; }
        public OperationType Operation { get; set; }
        public double Result { get; set; }

        public enum OperationType
        {
            sum,
            substract,
            divide,
            multiply
        }
    }
}
