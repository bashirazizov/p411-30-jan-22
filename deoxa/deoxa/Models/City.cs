using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deoxa.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
