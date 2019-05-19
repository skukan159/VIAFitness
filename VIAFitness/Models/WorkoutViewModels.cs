using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VIAFitness.Models
{
    public class CreateWorkoutViewModel
    {
        [Required]
        [Display(Name = "Workout Type")]
        public string WorkoutType { get; set; }
        [Required]
        [Display(Name = "Workout Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }

    public class DisplayWorkoutViewModel
    {
        [Key]
        public int WorkoutId { get; set; }
        public string WorkoutType { get; set; }
        [Display(Name = "Workout Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }

    public class DeleteWorkoutViewModel
    {
        [Key]
        public int WorkoutId { get; set; }
    }

    public class UpdateWorkoutViewModel
    {
        [Key]
        public int WorkoutId { get; set; }
        [Required]
        [Display(Name = "Workout Type")]
        public string WorkoutType { get; set; }
        [Required]
        [Display(Name = "Workout Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
    }
}