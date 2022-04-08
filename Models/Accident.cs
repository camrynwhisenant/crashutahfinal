using System;
using System.ComponentModel.DataAnnotations;
namespace CrashUtahProject.Models
{
    public class Accident
    {
        [Required]
        [Key]
        public double crash_id { get; set; }

        [Required(ErrorMessage = "Datetime is a required field")]
        public string crash_datetime { get; set; }

        [Required(ErrorMessage = "City is a required field")]
        public string city { get; set; }

        [Required(ErrorMessage = "County is a required field")]
        public string county_name { get; set; }

        [Required(ErrorMessage = "Severity is a required field")]
        public double crash_severity_id { get; set; }

        [Required(ErrorMessage = "Latitude is a required field")]
        public double lat_utm_y { get; set; }

        [Required(ErrorMessage = "Longitude is a required field")]
        public double long_utm_x { get; set; }

        [Required(ErrorMessage = "Route is a required field")]
        public double route { get; set; }

        [Required(ErrorMessage = "Main Road is a required field")]
        public string main_road_name { get; set; }

        [Required(ErrorMessage = "Milepoint is a required field")]
        public double milepoint { get; set; }

        [Required]
        public string bicyclist_involved { get; set; }

        [Required]
        public string commercial_motor_veh_involved { get; set; }

        [Required]
        public string distracted_driving { get; set; }

        [Required]
        public string domestic_animal_related { get; set; }

        [Required]
        public string drowsy_driving { get; set; }

        [Required]
        public string dui { get; set; }

        [Required]
        public string improper_restraint { get; set; }

        [Required]
        public string intersection_related { get; set; }

        [Required]
        public string motorcycle_involved { get; set; }

        [Required]
        public string night_dark_condition { get; set; }

        [Required]
        public string older_driver_involved { get; set; }

        [Required]
        public string overturn_rollover { get; set; }

        [Required]
        public string pedestrian_involved { get; set; }

        [Required]
        public string roadway_departure { get; set; }

        [Required]
        public string single_vehicle { get; set; }

        [Required]
        public string teenage_driver_involved { get; set; }

        [Required]
        public string unrestrained { get; set; }

        [Required]
        public string wild_animal_related { get; set; }

        [Required]
        public string work_zone_related { get; set; }
    }
}

