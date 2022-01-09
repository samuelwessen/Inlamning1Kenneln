using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class AnimalExtraServices : IAnimalExtraServices
    {
        public string NameOfService { get; set; }
        public decimal PriceOfService { get; set; }
    }
}
