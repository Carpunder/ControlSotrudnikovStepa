using ControlSotrudnikovStepa.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.ViewModels
{
    public class EmployeeDTO
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
        public string DepartmentName { get; set; }

        [ValidateNever]
        [Display(Name = "Должность")]
        public string PositionName { get; set; }
    }
}
