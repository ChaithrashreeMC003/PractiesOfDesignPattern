namespace UseingAppConfig
{
    public class Customer
    {
        Idal obj;
        public string Name { get; set; }
        public Customer(Idal newObj) => obj = newObj;
        public void Add()
        {
          
            obj.Add();
        }
    }
}
