using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Interfaces
{
    public interface IReciept
    {
        public DateTime RecieptDate { get; set; }
        public decimal RecieptTotalPrice { get; set; }
        public IAnimal RecieptAnimal { get; set; }
        public ICustomer RecieptCustomer { get; set; }
        public IAnimalExtraServices RecieptExtraServices { get; set; }
    }
}