namespace DpendencyInjection
{
    public class Customer
    {
        Idal obj;
        public string Name { get; set; }
        public Customer(Idal newObj)
        {
            obj = newObj;
        }
        public void Add()
        {
            //Idal obj;
            //if(1==1)
            //{
            //     obj = new SqlServer();
            //} else
            //{
            //    obj = new oracleServer();
            //}
            obj.Add();
        }
    }
}
