using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class Customer : ICustomer
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }        
        public IAnimal customerAnimals { get; set; }
    }
}
