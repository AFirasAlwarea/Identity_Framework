using System.Collections;
using System.Collections.Generic;

namespace Employees.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cities> Cities { get; set; }
    }
}