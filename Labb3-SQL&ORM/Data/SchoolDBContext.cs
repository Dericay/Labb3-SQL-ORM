using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Labb3_SQL_ORM.Data
{
    public partial class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
        {
        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseInfo> CourseInfos { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Personel> Personels { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = ANTON; Initial Catalog = SchoolDB; Integrated Security = True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Course1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Course");
            });

            modelBuilder.Entity<CourseInfo>(entity =>
            {
                entity.ToTable("CourseInfo");

                entity.Property(e => e.CourseInfoId).HasColumnName("CourseInfoID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeTime).HasColumnType("date");

                entity.Property(e => e.PersonelId).HasColumnName("PersonelID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseInfos)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Classroom_Course");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.CourseInfos)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_Classroom_Grades");

                entity.HasOne(d => d.Personel)
                    .WithMany(p => p.CourseInfos)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("FK_Classroom_Personel");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CourseInfos)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Classroom_Students");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Department1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Department");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.GradesId);

                entity.Property(e => e.GradesId).HasColumnName("GradesID");

                entity.Property(e => e.Grade1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Grade");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.ToTable("Personel");

                entity.Property(e => e.PersonelId).HasColumnName("PersonelID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Personels)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Personel_Department");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Class)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
