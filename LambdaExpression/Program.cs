namespace LambdaExpression
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello Lambda");

            var strings = new List<string> { "omar", "ali", "ziad", "ahmed" };
            var filters = strings.FindAll(s => s.Length == 4);
            foreach ( var filter in filters )
            {
                Console.WriteLine(filter);
            }
        }
    }
}