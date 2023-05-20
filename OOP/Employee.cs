namespace OOP
{
    class Employee
    {
        /*
         * I can use this way of Properties to check the setter method .
         */
        private int _id;
        private int _salary;
        public DateTime BirthDate { get; private set; }
        public readonly string _userName;

        public Employee(string userName)
        {
            _userName = userName;
        }

        public Employee(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        public string UserName
        {
            get { return _userName; }
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }


        public int Id
        {
            get => _id;
            set
            {
                if (value > 100)
                {
                    _id = value;
                }
                else
                {
                    _id = 100;
                }
            }
        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new InvalidOperationException("The Salary Must be greater than Zero !!");
                }
            }
        }


        /* 
         * The First way to implement Setter/Getter Properties 
         * 
         */

        //public int Salaray
        //{
        //    set { _salary = value; }
        //    get { return _salary; }
        //}

        /* 
         * I can do its much simpler if there is no logic in setters and getters prop.
         * Auto-Implemented Properties
         * but that will generate public fields not work for the _ private fields
         */

        //public int Salary { set; get; }
    }
}