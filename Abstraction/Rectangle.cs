namespace Abstraction
{
    public class Rectangle : Shape
    {
        // Abstract : should override
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }

        // Virtual : optional to override
        public override void Introduce()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}