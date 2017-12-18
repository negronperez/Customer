using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Customer.BusinessLogic
{
    public class CustomAddresManager
    {
        public static void Insert(Entity.CustomerAddress obj)
        {
            DataLayer.CustomerAddressData.Insert(obj);
        }
        public static void Update(Entity.CustomerAddress obj)
        {
            DataLayer.CustomerAddressData.Update(obj);
        }
        public static Entity.CustomerAddress GetById(int id)
        {
            return DataLayer.CustomerAddressData.GetById(id);
        }

        public static List<Entity.CustomerAddress> GetByAll()
        {
            return DataLayer.CustomerAddressData.GetByAll();
        }
    }
}
