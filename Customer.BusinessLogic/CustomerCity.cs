using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Customer.BusinessLogic
{
    public class CustomerCity
    {
        public static Entity.City GetById(int CityId)
        {
            return DataLayer.CustomerCity.GetById(CityId);
        }
        public static List<Entity.City> GetAll()
        {
           return DataLayer.CustomerCity.GetByAll();
        }
    }
}
