using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;

namespace Customer.DataLayer
{
    public class CustomerData
    {
        public static void Insert(Entity.Customer obj)
        {
            using (var model = new Entity.SeguroEntities1())
            {
                model.Entry<Entity.Customer>(obj).State = EntityState.Added;
                model.SaveChanges();
            }
        }
        public static void Update(Entity.Customer obj)
        {
            using (var model = new Entity.SeguroEntities1())
            {
                model.Entry<Entity.Customer>(obj).State = EntityState.Modified;
                model.SaveChanges();
            }
        }
        public static Entity.Customer GetById(Guid id)
        {
            using (var model = new Entity.SeguroEntities1())
            {
                var result = (from c in model.Customers where c.ID == id select c);
                return result.FirstOrDefault();
            }
        }

        public static List<Entity.Customer> GetByAll()
        {
            using (var model = new Customer.Entity.SeguroEntities1())
            {
                model.Configuration.ProxyCreationEnabled = false;//traer data si es nulo como quiera
                var result = (from c in model.Customers
                              .Include(c => c.CustomerAddresses) select c);
                return result.ToList();
            }
        }
    }
}
