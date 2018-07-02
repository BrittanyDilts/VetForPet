using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetForPet.Models
{
    public class Appointment
    {
        public IList<string> Symptoms { get; set; }
        public IList<string> Diagnosis { get; set; }
        public IList<string> Prescription { get; set; }
        public decimal Charge { get; set; }
    }
}
