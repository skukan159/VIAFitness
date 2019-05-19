using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaFitnessDataAccess.Models
{
    public class WorkoutModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Duration { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
