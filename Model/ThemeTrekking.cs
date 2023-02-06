using System;
using System.ComponentModel.DataAnnotations;

namespace WEB315_Trekking_Locations_Asg_01.Models
{
    public class ThemeTrekking
    {
        public int ID { get; set; }
        public string LocationName { get; set; }

        [DataType(DataType.Date)]
        public DateTime PlanningToVisit { get; set; }
        public string Place { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        /*public int Rating { get; set;}
        public string RelatedFilms {get; set;}*/
    }
}