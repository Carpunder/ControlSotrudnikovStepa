using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Оклад")]
        public float Salary { get; set; }
        [ValidateNever]
        [Display(Name = "Ставка")]
        public float? SalaryRate { get; set; }

        [Display(Name = "Отдел")]
        public int DepartmentId { get; set; }
        [ValidateNever]
        [Display(Name = "Отдел")]
        public Department Department { get; set; }

        [Display(Name = "Должность")]
        public int PositionId { get; set; }
        [ValidateNever]
        [Display(Name = "Должность")]
        public Position Position { get; set; }

        [ValidateNever]
        [Display(Name = "Табеля")]
        List<Timesheet> Timesheets { get; set; }
    }
}
