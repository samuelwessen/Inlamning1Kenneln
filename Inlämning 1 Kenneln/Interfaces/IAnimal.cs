using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Interfaces
{
    public interface IAnimal
    {        
        public string Name { get; set; }
        public string TypeOfAnimal { get; set; }
        public string IsCheckedIn { get; set; }
        public IAnimalExtraServices? extraService { get; set; }

    }
}
