using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlSotrudnikovStepa.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Departments]([Name], [BaseSalary]) VALUES ('Хозяйственный', 200)
GO
INSERT INTO[dbo].[Departments]([Name], [BaseSalary]) VALUES('Финансовый', 200)
GO
INSERT INTO[dbo].[Departments]([Name], [BaseSalary]) VALUES('Кадров', 200)
GO
INSERT INTO[dbo].[Departments]([Name], [BaseSalary]) VALUES('Общий', 200)
GO

INSERT INTO[dbo].[Positions]([Name], [BaseSalary]) VALUES('Старший', 200)
GO
INSERT INTO[dbo].[Positions]([Name], [BaseSalary]) VALUES('Ведущий', 200)
GO
INSERT INTO[dbo].[Positions]([Name], [BaseSalary]) VALUES('Cпециалист-эксперт', 200)
GO
INSERT INTO[dbo].[Positions]([Name], [BaseSalary]) VALUES('Главный специалист-эксперт', 200)
GO

INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Черникович Эльвира Степановна', 'ул. Могилевская 1/23', '80441234532', 800, 1.2, 1, 1)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Черникович Степан Степанович', 'ул. Пушкина 5/23', '80441234531', 800, 1.2, 1, 2)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Черникович Тимофей Степанович', 'ул. Могилевская 8/3', '80441234533', 800, 1.2, 1, 3)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Растигаев Степан Степанович', 'ул. Пушкина 1/19', '80441234534', 800, 1.2, 1, 4)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Растигаев Михаил Александрович', 'ул. Могилевская 3/9', '80441234535', 800, 1.2, 2, 1)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Растигаев Григорий Степанович', 'ул. Колотушкина 4/22', '80441234536', 800, 1.2, 2, 2)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Растигаев Свин Хрюшевич', 'ул. Колотушкина 12/32', '80441234537', 800, 1.2, 2, 3)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Растигаев Эдуард Степанович', 'ул. Свиновая 1/1', '80441234538', 800, 1.2, 2, 4)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Синькевич Эдуард Алексеевич', 'ул. Свиновая 7/45', '80441234539', 800, 1.2, 3, 1)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Синькевич Хрюн Свинович', 'ул. Капучинная 25/1', '80441234512', 800, 1.2, 3, 2)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Синькевич Алексей Алексеевич', 'ул. Брестская 77/32', '80441234522', 800, 1.2, 3, 3)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Велигурский Степан Степанович', 'ул. Капучинная 13/13', '80441234552', 800, 1.2, 3, 4)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Велигурский Александр Степанович', 'ул. Брестская 4/14', '80441234562', 800, 1.2, 4, 1)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Велигурская Елена Владимировна', 'ул. Петушковая 21/23', '80441234572', 800, 1.2, 4, 2)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Свин Степан Хрюкович', 'ул. Коковская 81/3', '80441234582', 800, 1.2, 4, 3)
GO
INSERT INTO[dbo].[Employees]([FIO], [Address], [PhoneNumber], [Salary], [SalaryRate], [DepartmentId], [PositionId])
VALUES('Прокопенко Павел Алексеевич', 'ул. Петушковая 19/23', '80441234592', 800, 1.2, 4, 4)
GO

INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 1)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 1)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 2)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 2)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 3)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 3)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 4)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 4)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 5)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 5)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 6)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 6)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 7)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 7)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 8)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 8)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 9)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 9)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 10)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 10)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 11)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 11)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-03', 6, 12)
GO
INSERT INTO[dbo].[Timesheets]([Date], [WorkedHours], [EmployeeId]) VALUES('2022-03-04', 6, 12)
GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
