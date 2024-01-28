using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class Department
    {
        public Department()
        {
            Personels = new HashSet<Personel>();
        }

        public int DepartmentId { get; set; }
        public string? Department1 { get; set; }

        public virtual ICollection<Personel> Personels { get; set; }
    }
}
