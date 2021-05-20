using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FitTrackAPI.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public double Waist { get; set; }
        public double Neck { get; set; }
        public double ? Hip { get; set; }
        public double Weight { get; set; }

        public DateTime Created { get; set; }

        public int UserId { get; set; }
        
        [JsonIgnore]
        public virtual User User { get; set; }

    }

}
