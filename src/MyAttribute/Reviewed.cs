namespace MyAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class Reviewed(string name) : Attribute
    {
        public string Reviewer { get; } = name;
    }
}
