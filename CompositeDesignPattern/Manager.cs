public class Manager : IEmployee
    {
        private string _name;
        private string _position;
        private List<IEmployee> _subordinates = new List<IEmployee>();

        public Manager(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public void AddEmployee(IEmployee emp)
        {
            _subordinates.Add(emp);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{_position}: {_name}");
            foreach (var emp in _subordinates)
            {
                emp.ShowDetails();
            }
        }
    }
