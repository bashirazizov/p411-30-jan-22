using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deoxa.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProjectToCategory> ProjectToCategoies { get; set; }
    }
}
