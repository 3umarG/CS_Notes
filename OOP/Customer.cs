namespace OOP
{
    public class Customer
    {
        public string Id;
        public string Name;
        public readonly List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(string id) : this() => Id = id;

        public Customer(string id, string name) : this(id)
        {
            Name = name;
        }
    }
}