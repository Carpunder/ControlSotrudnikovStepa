using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Отработанные часы")]
        public int WorkedHours { get; set; }

        [Display(Name = "Сотрудник")]
        public int EmployeeId { get; set; }
        [ValidateNever]
        [Display(Name = "Сотрудник")]
        public Employee Employee { get; set; }
    }
}
