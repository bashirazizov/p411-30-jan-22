using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deoxa.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PresidentId { get; set; }
        public List<City> Cities { get; set; }

        //do not add to db
        //public int Population
        //{
        //    get
        //    {
        //        int res = 0;
        //        foreach (var item in Cities)
        //        {
        //            res += item.Population;
        //        }
        //        return res;
        //    }
        //}
    }
}
