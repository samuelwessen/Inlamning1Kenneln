using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class Animal : IAnimal
    {        
        public string Name { get; set; }
        public string TypeOfAnimal { get; set; }
        public string IsCheckedIn { get; set; }
        public IAnimalExtraServices? extraService { get; set; }

    }
}
