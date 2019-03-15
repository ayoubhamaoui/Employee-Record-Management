using System;
using System.Collections.Generic;

namespace ERMS.Models
{
    public partial class TbEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Departement { get; set; }
        public string Gender { get; set; }
    }
}
