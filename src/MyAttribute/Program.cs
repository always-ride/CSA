using System.Reflection;

namespace MyAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyTestClass);
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                var message = $"Method: {method.Name}, ";
                var m2 = "NOT REVIEWED!";
                foreach (var attribute in method.GetCustomAttributes<Reviewed>())
                {
                    if (m2 == "NOT REVIEWED!") m2 = "";
                    m2 += $"Reviewed by: {attribute.Reviewer} ";
                }
                message += m2;
                Console.WriteLine(message);
            }
        }
    }
}
