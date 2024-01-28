using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class Student
    {
        public Student()
        {
            CourseInfos = new HashSet<CourseInfo>();
        }

        public int StudentId { get; set; }
        public long? PersonalNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Class { get; set; }

        public virtual ICollection<CourseInfo> CourseInfos { get; set; }
    }
}
