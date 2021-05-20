using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrackAPI.Models
{
    public enum Gender
    {
        Male, Female
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public double Height { get; set; }

        public DateTime Created { get; set; }

        public int SettingsId { get; set; }
        public Settings Settings { get; set; }

        public virtual List<Measurement> Measurements { get; set; }
    }
}
