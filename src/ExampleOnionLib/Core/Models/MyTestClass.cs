namespace ExampleOnionLib
{
    public class MyTestClass
    {
        [Reviewed("Dani")]   // Methode mit Attribut
        public void Dolt1()
        {
            Console.WriteLine("Executing Dolt1");
        }

        [Reviewed("Max")]    // Methode mit Attribut
        public void Dolt2()
        {
            Console.WriteLine("Executing Dolt2");
        }

        public void Dolt3()  // nicht überprüft
        {
            Console.WriteLine("Executing Dolt3");
        }
    }
}
