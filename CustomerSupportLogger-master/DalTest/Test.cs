using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace DalTest
{
    [TestFixture]
    public class Test
    {
        UserOperations op = null;
        public Test()
        {
           
            op = new UserOperations();
        }
        [TestCase("sanjay@gmail.com","sanjay",ExpectedResult =true)]
        [TestCase("ajay@gmail.com","sanjay",ExpectedResult =false)]
        [TestCase("ajay@gmail.com","ajay",ExpectedResult =true)]
        public bool Validate(string Email, string Password)
        {
            return op.ValidateUser(Email, Password);
        }
        [TestCase(4004 , ExpectedResult =false)]
        [TestCase(1002 , ExpectedResult =true)]
        public bool InsertCkeck(int id)
        {
            CustLogInfo c = new CustLogInfo();
            c.UserId = id;
           return op.Insert(c);
        }
    }
}
