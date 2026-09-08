using System.Diagnostics;

namespace MyAttribute
{
    public class MyTestClass
    {
        [Reviewed("John Doe")]
        [Reviewed("Danny Mac Askill")]
        public void DoIt1()
        {
            Console.WriteLine("Do it 1");
        }
        
        [Reviewed("Jane Smith")]
        public void DoIt2()
        {
            Console.WriteLine("Do it 2");
        }

        public void DoIt3()
        {
            Console.WriteLine("Do it 3");
        }
    }
}
