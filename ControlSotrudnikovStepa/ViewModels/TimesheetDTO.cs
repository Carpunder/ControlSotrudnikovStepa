using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.ViewModels
{
    public class TimesheetDTO
    {
        public int TimesheetId { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Отработанные часы")]
        public int WorkedHours { get; set; }
        [ValidateNever]
        [Display(Name = "Сотрудник")]
        public string EmployeeName { get; set; }
    }
}
