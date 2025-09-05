using Microsoft.Practices.Unity.Configuration;
using Unity;
using Unity.Injection;
using Unity.Resolution;
namespace DpendencyInjection
{
    class Program
    {
        //This UI Layer
        static void Main()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Idal, SqlServer>("sql");
            container.RegisterType<Idal, oracleServer>("oracle");
            container.RegisterType<Customer>("sqlobj", new InjectionConstructor(new ResolvedParameter("sql")));
            container.RegisterType<Customer>("oracleobj", new InjectionConstructor(new ResolvedParameter("oracle")));
            Customer c1 = container.Resolve<Customer>("");
            c1.Name = "Customer1";
            c1.Add();
          

        }
    }
}
