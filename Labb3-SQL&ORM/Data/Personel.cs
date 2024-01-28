using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class Personel
    {
        public Personel()
        {
            CourseInfos = new HashSet<CourseInfo>();
        }

        public int PersonelId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<CourseInfo> CourseInfos { get; set; }
    }
}
