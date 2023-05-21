namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {

            System.Console.WriteLine("Hello Inheritance");

            // That Called Upcasting : convert the derived class to Base Class.
            // The Same Two Objects refer to the same place at memory.
            var text = new Text();
            text.Draw();

            var circle = new Circle();
            circle.Draw();

            var trianlge = new Triangle();
            trianlge.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}