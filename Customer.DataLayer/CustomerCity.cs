using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Customer.DataLayer
{
    public class CustomerCity
    {
        public static Entity.City GetById(int id)
        {
            using (var model = new Entity.SeguroEntities1())
            {
                var result = (from c in model.Cities where c.CityId == id select c);
                return result.FirstOrDefault();
            }
        }

        public static List<Entity.City> GetByAll()
        {
            using (var model = new Entity.SeguroEntities1())
            {
                var result = (from c in model.Cities select c);
                return result.ToList();
            }
        }
    }
}
