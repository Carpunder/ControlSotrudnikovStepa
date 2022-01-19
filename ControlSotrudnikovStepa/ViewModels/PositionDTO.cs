using System.ComponentModel.DataAnnotations;

namespace ControlSotrudnikovStepa.ViewModels
{
    public class PositionDTO
    {
        public int PositionId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Базовый оклад")]
        public float BaseSalary { get; set; }
    }
}
