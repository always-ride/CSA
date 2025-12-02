namespace ExampleOnionLib
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ReviewedAttribute : Attribute
    {
        public string Reviewer { get; }

        public ReviewedAttribute(string reviewer)
        {
            Reviewer = reviewer;
        }
    }
}
