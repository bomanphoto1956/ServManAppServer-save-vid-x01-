using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<User> GetUsers()
        {
            List<User> Users = new List<User>();
            User User1 = new User();
            User1.Name = "nisse";
            User1.Adress = "gaten";
            Users.Add(User1);
            
            User User2 = new User();
            User2.Name = "nisse2";
            User2.Adress = "gaten2";
            User User3 = new User();
            
            User3.Name = "nisse3";
            User3.Adress = "gaten3";
            Users.Add(User1);

            return Users;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
