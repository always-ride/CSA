namespace ExampleOnionLib
{
    public delegate int MathOperation(int a, int b);

    public class DelegateDemo
    {
        static int Add(int x, int y) => x + y;

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static void Execute()
        {
            MathOperation op = Add;
            Console.WriteLine("Execute Addition:");
            Console.WriteLine(op(3, 4)); // 7
            Console.WriteLine();

            Console.WriteLine("Multicast:");
            op += Multiply; // Multicast
            foreach (MathOperation del in op.GetInvocationList())
            {
                Console.WriteLine(del(3, 4)); // 7 und 12
            }
        }
    }
}
