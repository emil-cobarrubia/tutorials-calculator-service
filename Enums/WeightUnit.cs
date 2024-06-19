using System.ComponentModel;

namespace Calculator.Enums
{
    public enum WeightUnit
    {
        [Description("Kilograms")]
        Kilograms = 1,

        [Description("Pounds")]
        Pounds = 2,

        [Description("Grams")]
        Grams = 3,

        [Description("Tonnes")]
        Tonnes = 4
    }
}
