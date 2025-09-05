

class Program
    {
        static void Main(string[] args)
        {
            // Create leaf objects
            IEmployee dev1 = new Developer("Alice", "Developer");
            IEmployee dev2 = new Developer("Bob", "Developer");

            // Create composite object (Manager)
            Manager manager = new Manager("Charlie", "Manager");

            // Manager has developers under him
            manager.AddEmployee(dev1);
            manager.AddEmployee(dev2);

            Console.WriteLine("Employee Hierarchy:\n");
            manager.ShowDetails();

            Console.ReadLine();
        }
    }
