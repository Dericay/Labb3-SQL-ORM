using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class Grade
    {
        public Grade()
        {
            CourseInfos = new HashSet<CourseInfo>();
        }

        public int GradesId { get; set; }
        public string? Grade1 { get; set; }

        public virtual ICollection<CourseInfo> CourseInfos { get; set; }
    }
}
