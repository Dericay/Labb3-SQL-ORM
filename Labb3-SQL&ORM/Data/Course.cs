using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class Course
    {
        public Course()
        {
            CourseInfos = new HashSet<CourseInfo>();
        }

        public int CourseId { get; set; }
        public string? Course1 { get; set; }

        public virtual ICollection<CourseInfo> CourseInfos { get; set; }
    }
}
