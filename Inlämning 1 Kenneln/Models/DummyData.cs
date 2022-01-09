using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class DummyData
    {
        public List<IAnimal> PopulateDummyDataAnimal(List<IAnimal> animalList)
        {
            animalList.Add(new Animal { Name = "Maskot", TypeOfAnimal = "Dog", IsCheckedIn = "Checked in" });
            animalList.Add(new Animal { Name = "Olle", TypeOfAnimal ="Cat", IsCheckedIn = "Not Checked in" });
            return animalList;
        }

        public List<ICustomer> PopulateDummyDataCustomer(List<ICustomer> customerList)
        {
            customerList.Add(new Customer { FirstName = "Micke", LastName = "Wessén", PhoneNumber = "0738142090" });
            customerList.Add(new Customer { FirstName = "Samuel", LastName = "Wessén", PhoneNumber = "0763398344" });
            customerList.Add(new Customer { FirstName = "Daniel", LastName = "Wessén", PhoneNumber = "0761111111" });
            return customerList;
        }

        public List<IAnimalExtraServices> PopulateDummyDataServices(List<IAnimalExtraServices> serviceList)
        {
            serviceList.Add(new AnimalExtraServices { NameOfService = "Bathing", PriceOfService = 20 });
            serviceList.Add(new AnimalExtraServices { NameOfService = "Claw cutting", PriceOfService = 10 });
            return serviceList;
        }
    }
}
