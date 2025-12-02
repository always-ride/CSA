using NUnit.Framework;
using System.Activities;

namespace UIPathDemo
{
    public class ReverseStringActivityTests
    {
        [Test]
        public void ReverseStringActivity_ShouldReverseText()
        {
            var activity = new ReverseStringActivity
            {
                Text = new InArgument<string>("Hallo")
            };

            var result = WorkflowInvoker.Invoke(activity);

            Assert.That("ollaH", Is.EqualTo(result["Result"]));
        }
    }
}
