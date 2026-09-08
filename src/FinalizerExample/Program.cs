namespace FinalizerExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateAndDestroySomething();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public static void CreateAndDestroySomething()
        {
            var a = new Something();
            a = null;
        }

        public class Something
        {
            private readonly Thread initialThread = Thread.CurrentThread;

            ~Something()
            {
                DisplayThreadInfo(initialThread);
                DisplayThreadInfo(Thread.CurrentThread);
            }

            private static void DisplayThreadInfo(Thread thread)
            {
                var message = thread != null
                        ? $"Thread ID: {thread.ManagedThreadId}"
                        : "Finalizer called, but thread is null.";
                Console.WriteLine(message);
            }
        }
    }
}
