using ControlSotrudnikovStepa.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.ViewModels
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Базовый оклад")]
        public float BaseSalary { get; set; }
    }
}
