using NUnit.Framework;
using SingletoneProject;

namespace SingletoneProject.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //    // Reset before each test to isolate tests
        //    Singletone.ResetForTests();
        //}

        [Test]
        public void Test1_SingletonCounter()
        {
            var obj1 = Singletone.GetIntence;
            Assert.AreEqual(1, obj1.Counter); // Passes
        }

        [Test]
        public void Test2_SingletonCounter_ExpectsFreshInstance()
        {
            var obj2 = Singletone.GetIntence;
            Assert.AreEqual(1, obj2.Counter); 
        }

        [Test]
        public void Test3_Singleton_SameInstanceReturned()
        {
            var obj1 = Singletone.GetIntence;
            var obj2 = Singletone.GetIntence;
            Assert.AreSame(obj1, obj2); // Always true
        }
    }
}
