namespace Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models.Etnities;

    public partial class ModelADO : DbContext
    {
        public ModelADO()
            : base("name=ModelADO")
        {
        }

        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<RecordBookLine> RecordBookLines { get; set; }
        public virtual DbSet<RecordBookLine1> RecordBookLines1 { get; set; }
        public virtual DbSet<RecordBook> RecordBooks { get; set; }
        public virtual DbSet<SemesterDicsipline> SemesterDicsiplines { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discipline>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer>()
                .Property(e => e.SecondName)
                .IsUnicode(false);

            modelBuilder.Entity<Lecturer>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<RecordBook>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<RecordBook>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<Semester>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.SecondName)
                .IsUnicode(false);
        }
    }
}
