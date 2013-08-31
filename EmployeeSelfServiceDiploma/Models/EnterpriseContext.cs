using EmployeeSelfServiceDiploma.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.Models
{
    public class EnterpriseContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Parcipiant> Parcipiants { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<TemplatedApplication> TemplatedApplications { get; set; }
        public DbSet<UserTemplatedApplication> UserTemplatedApplications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Collections.IEnumerable MaritalStatus { get; set; }
    }
}