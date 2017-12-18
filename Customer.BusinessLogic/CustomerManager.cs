using System;
using System.Linq;
using System.Collections.Generic;
namespace Customer.BusinessLogic
{
    public class CustomerManager
    {
        public static void Insert(Entity.Customer obj)
        {
            DataLayer.CustomerData.Insert(obj);
        }
        public static void Update(Entity.Customer obj)
        {
            DataLayer.CustomerData.Update(obj);
        }
        public static Entity.Customer GetById(Guid id)
        {
            return DataLayer.CustomerData.GetById(id);
        }

        public static List<Entity.Customer> GetByAll()
        {
            return DataLayer.CustomerData.GetByAll();
        }
    }
}
