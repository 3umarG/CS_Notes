namespace OOP
{
    class Program
    {
        public static void Main()
        {
            // Example of using properties and fields

            //try
            //{

            //    var emp = new Employee(new DateTime(2002, 5, 30));
            //    emp.Id = 2;
            //    emp.Salary = 200;

            //    Console.WriteLine(emp.Id);
            //    Console.WriteLine(emp.Salary);
            //    Console.WriteLine(emp.BirthDate);
            //    Console.WriteLine(emp.Age);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            var cookie = new HttpCookie();
            cookie["contentType"] = "Json";
            Console.WriteLine(cookie["contentType"] ?? "Not Found Key");
        }
    }
}