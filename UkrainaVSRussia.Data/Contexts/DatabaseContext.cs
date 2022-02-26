using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityProject.Domain.Models;

namespace EntityProject.Data.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectTeacher> SubjectTeachers { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=Asad; Trusted_connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(

                new Group
                {
                    Id = 1,
                    Name = ".NetBootcamp",
                    OpenedDate = "22.02.2002"
                },
                new Group
                {
                    Id = 2,
                    Name = "JavaBootcamp",
                    OpenedDate = "22.02.2002"
                },
                new Group
                {
                    Id = 3,
                    Name = "GoBootcamp",
                    OpenedDate = "22.02.2002"
                }
                );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    FirstName = "Muhammadkarim",
                    LastName = "To'xtaboyev",
                    Experience = 9,
                    GroupId = 1,
                },
                new Teacher
                {
                    Id = 2,
                    FirstName = "Javohir",
                    LastName = "Buzrukov",
                    Experience = 9,
                    GroupId = 1,
                },
                new Teacher
                {
                    Id = 3,
                    FirstName = "O'tkirbek",
                    LastName = "Sobirov",
                    Experience = 9,
                    GroupId = 2,
                },
                new Teacher
                {
                    Id = 4,
                    FirstName = "Abduvohid",
                    LastName = "Karimov",
                    Experience = 9,
                    GroupId = 2,
                },
                new Teacher
                {
                    Id = 5,
                    FirstName = "Davron",
                    LastName = "Yusupov",
                    Experience = 9,
                    GroupId = 3,
                },
                new Teacher
                {
                    Id = 6,
                    FirstName = "Tohir",
                    LastName = "Fozilov",
                    Experience = 9,
                    GroupId = 3,
                });
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    Name = "dotnet"
                },
                new Subject
                {
                    Id = 2,
                    Name = "java"
                },
                new Subject
                {
                    Id = 3,
                    Name = "go"
                },
                new Subject
                {
                    Id = 4,
                    Name = "foundation",

                });
            modelBuilder.Entity<SubjectTeacher>().HasData(
                new SubjectTeacher
                {
                    Id = 1,
                    SubjectId = 1,
                    TeacherId = 1,
                },
                new SubjectTeacher
                {
                    Id = 2,
                    SubjectId = 1,
                    TeacherId = 2,
                },
                new SubjectTeacher
                {
                    Id = 3,
                    SubjectId = 2,
                    TeacherId = 3,
                },
                new SubjectTeacher
                {
                    Id = 4,
                    SubjectId = 2,
                    TeacherId = 4,
                },
                new SubjectTeacher
                {
                    Id = 5,
                    SubjectId = 3,
                    TeacherId = 5,
                },
                new SubjectTeacher
                {
                    Id = 6,
                    SubjectId = 3,
                    TeacherId = 6,
                },
                new SubjectTeacher
                {
                    Id = 7,
                    SubjectId = 4,
                    TeacherId = 5,
                },
                new SubjectTeacher
                {
                    Id = 8,
                    SubjectId = 4,
                    TeacherId = 1,
                },
                new SubjectTeacher
                {
                    Id = 9,
                    SubjectId = 4,
                    TeacherId = 3,
                });
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Asadbek",
                    LastName = "Latipov",
                    Age = 21,
                    Email = "asad@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 1
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Muboshshir",
                    LastName = "Fozilov",
                    Age = 22,
                    Email = "muboshir@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 2
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Homid",
                    LastName = "Rozipv",
                    Age = 21,
                    Email = "homid@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 3
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Orip",
                    LastName = "Yuldashev",
                    Age = 20,
                    Email = "asad@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 1
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Avaz",
                    LastName = "Davlatov",
                    Age = 22,
                    Email = "avaz@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 2
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Umar",
                    LastName = "Mahmudjanov",
                    Age = 22,
                    Email = "umar@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 3
                },
                new Student
                {
                    Id = 7,
                    FirstName = "Usmon",
                    LastName = "Qodirov",
                    Age = 19,
                    Email = "usmon@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 1
                },
                new Student
                {
                    Id = 8,
                    FirstName = "Abdurahmon",
                    LastName = "Zafarov",
                    Age = 21,
                    Email = "abdurahmon@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 2
                },
                new Student
                {
                    Id = 9,
                    FirstName = "Bobur",
                    LastName = "Boburov",
                    Age = 20,
                    Email = "bobur@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 3
                },
                new Student
                {
                    Id = 10,
                    FirstName = "Obid",
                    LastName = "Obidov",
                    Age = 21,
                    Email = "obid@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 1
                },
                new Student
                {
                    Id = 11,
                    FirstName = "Ahror",
                    LastName = "Ahrarov",
                    Age = 21,
                    Email = "ahror@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 2
                },
                new Student
                {
                    Id = 12,
                    FirstName = "Muhriddin",
                    LastName = "Muhriddinov",
                    Age = 21,
                    Email = "mhriddin@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 3
                },
                new Student
                {
                    Id = 13,
                    FirstName = "Tohir",
                    LastName = "Tohirov",
                    Age = 22,
                    Email = "tohirov@gmail.com",
                    PhoneNumber = "99 999 99 99",
                    GroupId = 1
                });

        }
    }
}
