namespace ExampleOnionLib
{
    public delegate int MathOperation(int a, int b);

    public class DelegateDemo
    {
        private static readonly MathOperation Add = (x, y) => x + y;

        private static readonly MathOperation Multiply = (x, y) => x * y;

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
                Console.WriteLine(del.Invoke(3, 4)); // 7 und 12
            }
        }
    }
}
