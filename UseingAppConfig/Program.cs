using Microsoft.Practices.Unity.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;
namespace UseingAppConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();
            Customer c1 = container.Resolve<Customer>();
            c1.Name = "Chaithra";
            c1.Add();
            Customer c2 = container.Resolve<Customer>(new ParameterOverride("newObj", container.Resolve<Idal>("oracle")));
            c2.Name = "Customer2";
            c2.Add();
        }
    }
}
