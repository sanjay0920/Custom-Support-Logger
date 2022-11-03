using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserOperations
    {
        CustomerEntities userContext = null;
        public UserOperations()
        {
            userContext = new CustomerEntities();
        }
        public bool ValidateUser(string email, string pass)
        {
            bool ans = false;
            var found1 = userContext.UserInfoes.ToList();
            var found = found1.Find(x => x.Email == email);
            if (found != null)
            {
                if (found.Password == pass)
                {
                    ans = true;
                }
            }
            return ans;
        }
        public bool Insert(CustLogInfo c)
        {
            bool ans = true;
            try
            {
                userContext.CustLogInfoes.Add(c);
                userContext.SaveChanges();
                return ans;
            }
            catch (Exception)
            {
                ans = false;
                return ans;
            }
        }
    }
}
