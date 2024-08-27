using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFamily.Domain.Models.Shared
{
    public class Requisites
    {
        private Requisites()
        {
            
        }
        public IReadOnlyList<Requisite> Requisite { get; private set; }
    }
}
