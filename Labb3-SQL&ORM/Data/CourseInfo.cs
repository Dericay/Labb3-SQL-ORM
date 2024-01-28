using System;
using System.Collections.Generic;

namespace Labb3_SQL_ORM.Data
{
    public partial class CourseInfo
    {
        public int CourseInfoId { get; set; }
        public int? CourseId { get; set; }
        public int? PersonelId { get; set; }
        public int? StudentId { get; set; }
        public int? GradeId { get; set; }
        public DateTime? GradeTime { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Grade? Grade { get; set; }
        public virtual Personel? Personel { get; set; }
        public virtual Student? Student { get; set; }
    }
}
