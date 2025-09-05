using DefferentTypesOfEmployee;

class Program
{
    static void Main()
    {
        Employeefactoryclass factory = new Employeefactoryclass();
        var intern = factory.GetInstence("Intern");
        intern.Payment();
        var parmanent = factory.GetInstence("Permanent");
        parmanent.Payment();
    }
}
