namespace Abstraction
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // Abstract Class can have 3 types of method inside it :

        // 1- Abstract method : virtual by itself , force the derived classes to override it
        public abstract void Draw();

        // 2- Virtual method  : can have implementaion , but any derived class can override it
        // to make its own implementaion.
        public virtual void Introduce()
        {
            Console.WriteLine("This is Shape");
        }

        // 3- Normal method : not virtual , has its own implementaion
        // no class can see it or override it
        // common used for the same mechanism for all derived classes لو عندي method عاوزها تكون موحدة لكل ال derivd classes ومش هتتغير
        public void CopyShape()
        {
            Console.WriteLine("Copied !!!");
        }
    }
}