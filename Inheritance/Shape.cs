namespace Inheritance
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }


        // By using virtual keyword , I enable the method to be able to override from other derived classes
        // The method is not able to override by itself .
        // I should notate it by virtual مرئي to make other classes see "virtual" .
        public virtual void Draw()
        {
            Console.WriteLine("Draw Shape the base version");
        }
    }
}