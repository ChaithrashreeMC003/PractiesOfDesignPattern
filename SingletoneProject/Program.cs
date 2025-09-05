using SingletoneProject;

class Program
{
    static void Main(String[] args)
    {
        Parallel.Invoke(
        () => PrintStuentDetails(),
        () => PrintEmployeeDetails()
        );
    }

    private static void PrintEmployeeDetails()
    {
        Singletone employeeDetails = Singletone.GetIntence;
        employeeDetails.PrintMessage("From employee Hi");
    }

    private static void PrintStuentDetails()
    {
        Singletone studentDetails = Singletone.GetIntence;
        studentDetails.PrintMessage("From student Hello!");
    }
}