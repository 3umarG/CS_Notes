namespace Inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public Car(int id) : base(id)
        {
            Console.WriteLine("From Car Constructor : {0}" , Id);
        }
    }
}