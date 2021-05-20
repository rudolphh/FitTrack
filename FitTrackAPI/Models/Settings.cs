using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FitTrackAPI.Models
{
    public enum Unit
    {
        Metric, Imperial
    }

    public class Settings
    {
        public int Id { get; set; }

        public Unit Unit { get; set; }

        public int UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
