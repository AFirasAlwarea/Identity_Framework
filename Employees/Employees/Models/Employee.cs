using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employees.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        
        [DisplayName("Country")]
        public int CountryId { get; set; }

        [DisplayName("City")]
        public int CityId { get; set; }

    }
}