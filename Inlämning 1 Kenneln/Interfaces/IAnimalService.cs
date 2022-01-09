using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Interfaces
{
    public interface IAnimalService
    {
        public List<IAnimal> RegisterAnimal(List<IAnimal> animals);
        public void CheckInAnimal(List<IAnimal> animalList);
        public void CheckOutAnimal(List<IAnimal> animalList);
        public void AddServicesToAnimal(List<IAnimalExtraServices> serviceList, List<IAnimal> animalList);
    }
}

