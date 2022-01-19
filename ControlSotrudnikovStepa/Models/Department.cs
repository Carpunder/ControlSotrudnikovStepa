using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Базовый оклад")]
        public float BaseSalary { get; set; }

        [ValidateNever]
        [Display(Name = "Сотрудники")]
        public List<Employee> Employees { get; set; }
    }
}
