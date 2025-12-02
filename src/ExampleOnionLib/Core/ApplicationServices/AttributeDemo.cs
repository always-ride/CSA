using System.Reflection;

namespace ExampleOnionLib
{
    public class AttributeDemo
    {
        public static void Execute()
        {
            var type = typeof(MyTestClass);
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                var attr = method.GetCustomAttribute<ReviewedAttribute>();
                if (attr != null)
                {
                    Console.WriteLine($"{method.Name} - Reviewed by {attr.Reviewer}");
                }
                else
                {
                    Console.WriteLine($"{method.Name} - NOT REVIEWED!");
                }
            }
        }
    }
}
