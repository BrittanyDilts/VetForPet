using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetForPet.Models
{
    public enum Species
    {
        Dog,
        Cat,
        Rabbit,
        Bird,
        Ferret,
        Hamster,
        Lizard,
        Pig,
        Goat
    }
    public class Pet
    {
        public string Name { get; set; }
        public Species Species { get; set; }
        public IList<Appointment> Appointments { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
    }
}
