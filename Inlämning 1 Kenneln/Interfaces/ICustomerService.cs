using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Interfaces
{
    public interface ICustomerService
    {
        public List<ICustomer> RegisterCustomer(List<ICustomer> customers);
        public void ConnectCustomerToAnimal(List<IAnimal> animalList, List<ICustomer> customerList);
    }
}
