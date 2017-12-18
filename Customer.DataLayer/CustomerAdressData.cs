using System;
using System.Linq;
using System.Collections.Generic;
namespace Customer.DataLayer
{
    public class CustomerAddressData
    {
        public static void Insert(Entity.CustomerAddress obj)
        {
            using (var model = new Entity.SeguroEntities())
            {
                model.Entry<Entity.CustomerAddress>(obj).State = System.Data.Entity.EntityState.Added;
                model.SaveChanges();
            }
        }
        public static void Update(Entity.CustomerAddress obj)
        {
            using (var model = new Entity.SeguroEntities())
            {
                model.Entry<Entity.CustomerAddress>(obj).State = System.Data.Entity.EntityState.Modified;
                model.SaveChanges();
            }
        }
        public static Entity.CustomerAddress GetById(int id)
        {
            using (var model = new Entity.SeguroEntities())
            {
                var result = (from c in model.CustomerAddresses where c.CustomerId == id select c);
                return result.FirstOrDefault();
            }
        }

        public static List<Entity.CustomerAddress> GetByAll()
        {
            using (var model = new Entity.SeguroEntities())
            {
                var result = (from c in model.CustomerAddresses select c);
                return result.ToList();
            }
        }
    }
}
