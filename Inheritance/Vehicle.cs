namespace Inheritance
{
    public class Vehicle
    {
        // Attributes
        private readonly int id;

        // Constructors
        public Vehicle()
        {

        }

        public Vehicle(int id)
        {
            this.id = id;
            Console.WriteLine("From Vehicle Constructor : {0}" , Id);
        }

        // Properties  : Setters / Getters
        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}