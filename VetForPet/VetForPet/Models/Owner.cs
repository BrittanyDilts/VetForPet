using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetForPet.Models
{
    public class Owner
    {
        public string Name { get;set;}
        public IList<Pet> Pets { get; set; }
        public decimal Balance { get; set; }
    }
}
