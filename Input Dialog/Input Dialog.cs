using System;
using System.Activities;
using System.ComponentModel;

namespace Vivi.Package.Test
{
    public class InputDialog : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<double> FirstNumber { get; set; }

        [Category("Input")]
        public InArgument<double> SecondNumber { get; set; }

        [Category("Output")]
        public OutArgument<double> ResultNumber { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);
            var result = Math.Pow(firstNumber + secondNumber, 2);
            ResultNumber.Set(context, result);
            //throw new NotImplementedException();
        }
    }
}
