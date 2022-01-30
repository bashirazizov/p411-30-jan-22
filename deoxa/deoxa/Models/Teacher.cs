using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deoxa.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        List<Student> students { get; set; }
    }
}
