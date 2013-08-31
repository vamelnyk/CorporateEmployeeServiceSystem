using EmployeeSelfServiceDiploma.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeSelfServiceDiploma.DAL
{
    public class EnterpriseInitializer : DropCreateDatabaseIfModelChanges<EnterpriseContext>
    {
        protected override void Seed(EnterpriseContext context)
        {
            var marital = new List<MaritalStatus>
            {
                new MaritalStatus { Status = "Неодружений" },
                new MaritalStatus { Status = "Одружений" }
            };
            marital.ForEach(s => context.MaritalStatuses.Add(s));
            context.SaveChanges();

            var gender = new List<Gender>
            {
                new Gender { Name = "Чоловіча" },
                new Gender { Name = "Жіноча" }
            };
            gender.ForEach(s => context.Genders.Add(s));
            context.SaveChanges();

            var projectStatuses = new List<ProjectStatus>
            {
                new ProjectStatus { Status = "Активний" },
                new ProjectStatus { Status = "Виконаний" },
                new ProjectStatus { Status = "Провалений" }
            };
            projectStatuses.ForEach(s => context.ProjectStatuses.Add(s));
            context.SaveChanges();

            var taskStatuses = new List<TaskStatus>
            {
                new TaskStatus { Status = "Активний" },
                new TaskStatus { Status = "Виконаний" },
                new TaskStatus { Status = "Провалений" }
            };
            taskStatuses.ForEach(s => context.TaskStatuses.Add(s));
            context.SaveChanges();

            var tasks = new List<Task>
            {
                new Task { Title = "Інтерфейс системи самообслуговування", Description = "Необхідно спроектувати інтерфейс для системи. Процес включає розробку графічних об'єктів, PSD шаблону і HTML сторінок сайту.", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Application SketchFlow", Description = "Необхідно розробити сценарії роботи для проекту FopMine. Особливо важливо продумати взаємодію з додатком.", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Дизайн Windows 8 додатку", Description = "Спроектувати дизайн для eFarmer", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Завдання 4", Description = "Some text ...", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Завдання 5", Description = "Some text ...", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Завдання 6", Description = "Some text ...", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 1 },
                new Task { Title = "Завдання 7", Description = "Some text ...", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 2 },
                new Task { Title = "Завдання 8", Description = "Some text ...", DueDate = DateTime.Parse("2013-09-01"), TaskStatusID = 3 }
            };
            tasks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();

            var projects = new List<Project>
            {
                new Project { Name = "Project 1", ProjectStatusID = 1, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 2", ProjectStatusID = 2, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 3", ProjectStatusID = 3, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 4", ProjectStatusID = 1, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 5", ProjectStatusID = 2, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 6", ProjectStatusID = 3, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 7", ProjectStatusID = 1, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") },
                new Project { Name = "Project 8", ProjectStatusID = 2, StartDate = DateTime.Parse("2002-09-01"), EndDate = DateTime.Parse("2002-09-01") }
            };
            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { Name = "Development" },
                new Department { Name = "Marketing" },
                new Department { Name = "Management" },
                new Department { Name = "Technical" }
            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var positions = new List<Position>
            {
                new Position { DepartmentID = 1, Name = "Developer" },
                new Position { DepartmentID = 1, Name = "Designer" },
                new Position { DepartmentID = 1, Name = "QA Engineer" },
                new Position { DepartmentID = 1, Name = "Illustrator" },
                new Position { DepartmentID = 1, Name = "Tester" }
            };
            positions.ForEach(s => context.Positions.Add(s));
            context.SaveChanges();

            var trainings = new List<Training>
            {
                new Training { Title = "Training 1", Description = "training description ...", Date = DateTime.Parse("2002-09-01") },
                new Training { Title = "Training 2", Description = "training description ...", Date = DateTime.Parse("2002-09-01") },
                new Training { Title = "Training 3", Description = "training description ...", Date = DateTime.Parse("2002-09-01") },
                new Training { Title = "Training 4", Description = "training description ...", Date = DateTime.Parse("2002-09-01") }
            };
            trainings.ForEach(s => context.Trainings.Add(s));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article { Title = "Article Title 1", Content = "Content 1", Date = DateTime.Parse("2002-09-01") },
                new Article { Title = "Article Title 2", Content = "Content 2", Date = DateTime.Parse("2002-09-01") },
                new Article { Title = "Article Title 3", Content = "Content 3", Date = DateTime.Parse("2002-09-01") }
            };
            articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();

            var messages = new List<Message>
            {
                new Message { Theme = "Message 1", Content = "message body", SendingDate = DateTime.Parse("2002-09-01") },
                new Message { Theme = "Message 2", Content = "message body 2", SendingDate = DateTime.Parse("2002-09-01") },
                new Message { Theme = "Message 1", Content = "message body 3", SendingDate = DateTime.Parse("2002-09-01") }
            };
            messages.ForEach(s => context.Messages.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { UserName = "vamelnyk", Password = "123456", FirstName = "Volodymyr",   LastName = "Melnyk", BirthDate = DateTime.Parse("1992-04-10"), MaritalStatusID = 1, PositionID = 1, Address = "Якіра, 10", Email = "v.a.melnyk@mail.ru", Im = "v.a.melnyk", Phone = "+380668210376", Photo = "~/Content/images/employees/profile.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Meredith", Password = "123456", FirstName = "Meredith", LastName = "Alonso",    BirthDate = DateTime.Parse("1991-09-01"), MaritalStatusID = 1, PositionID = 2, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/123.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Arturo", Password = "123456", FirstName = "Arturo",   LastName = "Anand",     BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 3, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/1234.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Gytis", Password = "123456", FirstName = "Gytis",    LastName = "Barzdukas", BirthDate = DateTime.Parse("1990-09-01"), MaritalStatusID = 1, PositionID = 4, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/12345.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Yan", Password = "123456", FirstName = "Yan",      LastName = "Li",        BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 1, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/123456.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Peggy", Password = "123456", FirstName = "Peggy",    LastName = "Justice",   BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 2, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/1234567.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Laura", Password = "123456", FirstName = "Laura",    LastName = "Norman",    BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 3, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/12345678.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "Nino", Password = "123456", FirstName = "Nino",     LastName = "Olivetto",  BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 4, Address = "Address", Email = "i@i.ua", Im = "some", Phone = "111", Photo = "~/Content/images/employees/123456789.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "ivan", Password = "123456", FirstName = "Ivan",    LastName = "Ivanov", BirthDate = DateTime.Parse("1990-09-01"), MaritalStatusID = 1, PositionID = 4, Address = "Петропавлявська, 28", Email = "ivan@meta.ua", Im = "ivan", Phone = "+380666666666", Photo = "~/Content/images/employees/12.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "petr", Password = "123456", FirstName = "Petro",      LastName = "Petrov",        BirthDate = DateTime.Parse("1988-10-01"), MaritalStatusID = 2, PositionID = 3, Address = "Шевченка, 15", Email = "petrenko@gmail.com", Im = "petrenko", Phone = "+380951329856", Photo = "~/Content/images/employees/1234567890.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "nik", Password = "123456", FirstName = "Nik",    LastName = "Munkovich",   BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 2, PositionID = 4, Address = "Кірова, 12", Email = "nick@tem.com", Im = "nick", Phone = "+380678235466", Photo = "~/Content/images/employees/12345678901.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "marcus", Password = "123456", FirstName = "Marcus",    LastName = "Isko",    BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 2, PositionID = 3, Address = "Велика, 7", Email = "marcus@i.ua", Im = "marcus", Phone = "+380762398566", Photo = "~/Content/images/employees/123456789012.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() },
                new Employee { UserName = "vanesa", Password = "123456", FirstName = "Vanessa",     LastName = "Milco",  BirthDate = DateTime.Parse("1992-09-01"), MaritalStatusID = 1, PositionID = 2, Address = "Петляри, 12, кв. 5", Email = "vanessa@com.com", Im = "vanessa", Phone = "+380677777777", Photo = "~/Content/images/employees/1234567890123.png", inboxMessages = new List<Message>(), outboxMessages = new List<Message>() }
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var applications = new List<Application>
            {
                new Application { Title = "Заява на перерахування заробітної плати", Body = "Прошу перерахувати мої щомічні нарахування (заробітна плата і премія) на банківський рахунок.", Date = DateTime.Parse("2002-09-01"), EmployeeID = 1 },
                new Application { Title = "Заява №2", Body = "Вміст заявки", Date = DateTime.Parse("2013-09-01"), EmployeeID = 2 },
                new Application { Title = "Заява №3", Body = "Вміст заявки", Date = DateTime.Parse("2013-09-11"), EmployeeID = 1 }
            };
            applications.ForEach(s => context.Applications.Add(s));
            context.SaveChanges();

            var templite_apps = new List<TemplatedApplication>
            {
                new TemplatedApplication { Title = "Заява на відпустку", templatedField1 = "02.07.2013", templatedField2 = "23.07.2013", Date = DateTime.Parse("2012-09-01") },
                new TemplatedApplication { Title = "Заява на лікарняний", templatedField1 = "Вміст заявки", Date = DateTime.Parse("2013-09-01") },
                new TemplatedApplication { Title = "Заява на відрядження", templatedMultiField3 = "Вміст заявки", Date = DateTime.Parse("2013-09-11") }
            };
            templite_apps.ForEach(s => context.TemplatedApplications.Add(s));
            context.SaveChanges();

            var salaries = new List<Salary>
            {
                new Salary { Value = "4800", Premium = "500", Date = DateTime.Parse("2012-10-28"), EmployeeID = 1 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 2 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 3 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 4 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 5 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 6 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 7 },
                new Salary { Value = "3000", Premium = "500", Date = DateTime.Parse("2002-09-01"), EmployeeID = 8 },
                new Salary { Value = "5000", Premium = "650", Date = DateTime.Parse("2012-11-29"), EmployeeID = 1 },
                new Salary { Value = "4700", Premium = "360", Date = DateTime.Parse("2012-12-28"), EmployeeID = 1 },
                new Salary { Value = "5000", Premium = "400", Date = DateTime.Parse("2013-01-30"), EmployeeID = 1 },
                new Salary { Value = "5100", Premium = "420", Date = DateTime.Parse("2013-02-28"), EmployeeID = 1 },
                new Salary { Value = "5100", Premium = "500", Date = DateTime.Parse("2013-03-29"), EmployeeID = 1 },
                new Salary { Value = "5050", Premium = "270", Date = DateTime.Parse("2013-04-27"), EmployeeID = 1 },
                new Salary { Value = "5120", Premium = "520", Date = DateTime.Parse("2013-05-29"), EmployeeID = 1 },
                new Salary { Value = "5250", Premium = "300", Date = DateTime.Parse("2013-06-30"), EmployeeID = 1 }
            };
            salaries.ForEach(s => context.Salaries.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment { EmployeeID = 1, TaskID = 1 },
                new Enrollment { EmployeeID = 1, TaskID = 2 },
                new Enrollment { EmployeeID = 1, TaskID = 3 },
                new Enrollment { EmployeeID = 2, TaskID = 4 },
                new Enrollment { EmployeeID = 2, TaskID = 5 },
                new Enrollment { EmployeeID = 2, TaskID = 6 },
                new Enrollment { EmployeeID = 3, TaskID = 1 },
                new Enrollment { EmployeeID = 4, TaskID = 1 },
                new Enrollment { EmployeeID = 4, TaskID = 2 },
                new Enrollment { EmployeeID = 5, TaskID = 3 },
                new Enrollment { EmployeeID = 6, TaskID = 4 },
                new Enrollment { EmployeeID = 7, TaskID = 5 },
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var parcipiants = new List<Parcipiant>
            {
                new Parcipiant { EmployeeID = 1, ProjectID = 1 },
                new Parcipiant { EmployeeID = 1, ProjectID = 2 },
                new Parcipiant { EmployeeID = 1, ProjectID = 3 },
                new Parcipiant { EmployeeID = 2, ProjectID = 4 },
                new Parcipiant { EmployeeID = 2, ProjectID = 5 },
                new Parcipiant { EmployeeID = 2, ProjectID = 6 },
                new Parcipiant { EmployeeID = 3, ProjectID = 1 },
                new Parcipiant { EmployeeID = 4, ProjectID = 1 },
                new Parcipiant { EmployeeID = 4, ProjectID = 2 },
                new Parcipiant { EmployeeID = 5, ProjectID = 3 },
                new Parcipiant { EmployeeID = 6, ProjectID = 4 },
                new Parcipiant { EmployeeID = 7, ProjectID = 5 },
            };
            parcipiants.ForEach(s => context.Parcipiants.Add(s));
            context.SaveChanges();

            var user_temliteapps = new List<UserTemplatedApplication>
            {
                new UserTemplatedApplication { EmployeeID = 1, TemplatedApplicationID = 1 },
                new UserTemplatedApplication { EmployeeID = 1, TemplatedApplicationID = 2 },
                new UserTemplatedApplication { EmployeeID = 1, TemplatedApplicationID = 3 },
                new UserTemplatedApplication { EmployeeID = 2, TemplatedApplicationID = 1 },
                new UserTemplatedApplication { EmployeeID = 2, TemplatedApplicationID = 2 },
                new UserTemplatedApplication { EmployeeID = 2, TemplatedApplicationID = 3 },
                new UserTemplatedApplication { EmployeeID = 3, TemplatedApplicationID = 2 },
                new UserTemplatedApplication { EmployeeID = 4, TemplatedApplicationID = 1 },
                new UserTemplatedApplication { EmployeeID = 4, TemplatedApplicationID = 2 },
                new UserTemplatedApplication { EmployeeID = 5, TemplatedApplicationID = 3 },
                new UserTemplatedApplication { EmployeeID = 6, TemplatedApplicationID = 1 },
                new UserTemplatedApplication { EmployeeID = 7, TemplatedApplicationID = 1 },
            };
            user_temliteapps.ForEach(s => context.UserTemplatedApplications.Add(s));
            context.SaveChanges();

            employees[0].inboxMessages.Add(messages[0]);
            employees[0].outboxMessages.Add(messages[1]);
            employees[1].outboxMessages.Add(messages[2]);
            context.SaveChanges();
        }
    }
}