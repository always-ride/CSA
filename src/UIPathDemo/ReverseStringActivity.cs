using System;
using System.Linq;
using System.Activities;

namespace UIPathDemo
{
    public class ReverseStringActivity : CodeActivity
    {
        // Input Argument
        [RequiredArgument]
        public InArgument<string> Text { get; set; }

        // Output Argument
        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var text = Text.Get(context);
            var reversed = new string(text?.ToCharArray().Reverse().ToArray());
            Result.Set(context, reversed);
        }
    }
}
