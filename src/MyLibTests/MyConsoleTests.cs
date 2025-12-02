using MyLib;

namespace MyLibTests
{
    public class MyConsoleTests
    {
        private IConsoleTestClient sut;

        [SetUp]
        public void Setup()
        {
            // GIVEN
            sut = MyConsole.Create();
        }

        [Test]
        public void PrintToConsolePrintsSomething()
        {
            // GIVEN
            const string message = "Something";

            // WHEN            
            sut.PrintToConsole(message);

            // THEN
            Assert.That(sut.LastlyPrintedText, Is.EqualTo(message));
        }

        [Test]
        public void PrintToConsolePrintsSomethingElse()
        {
            // GIVEN
            const string message = "SomethingElse";

            // WHEN            
            sut.PrintToConsole(message);

            // THEN
            Assert.That(sut.LastlyPrintedText, Is.EqualTo(message));
        }
    }
}
