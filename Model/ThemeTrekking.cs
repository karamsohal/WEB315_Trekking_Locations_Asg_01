using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Trekking_Locations_Asg_01.Models
{
    public class ThemeTrekking
    {
        public int ID { get; set; }
        [StringLength(32, MinimumLength = 4)]
        [Display(Name ="Location Name")]
        [Required(ErrorMessage = "Location Name is required.")]
        public string LocationName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Planning To Visit")]
        [Required(ErrorMessage = "Visit Date is required.")]
        public DateTime PlanningToVisit { get; set; }
        
        [StringLength(32, MinimumLength = 4)]
        [Required(ErrorMessage = "Place Name is required.")]
        public string Place { get; set; }
        
        [StringLength(32, MinimumLength = 4)]
        [Required(ErrorMessage = "State Name is required.")]
        public string State { get; set; }
        
        [StringLength(32, MinimumLength = 4)]
        [Required(ErrorMessage = "Country Name is required.")]
        public string Country { get; set; }
        
        [Range(5000, 30000)]
        [Required(ErrorMessage = "Height from Ground to Top is required.")]
        [Display(Name ="Height (in ft)")]
        public int Height { get; set; }
        
        [StringLength(250, MinimumLength = 4)]
        [Required(ErrorMessage = "Popularity about Trekking spot is required.")]
        public string Popularity { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "First letter must be uppercase & no special characters or numbers allowed")]
        [StringLength(32, MinimumLength = 4)]
        [Display(Name ="Visitor's Name")]
        [Required(ErrorMessage = "Visitor Name is required.")]
        public string VisitorName { get; set; }
    }
}