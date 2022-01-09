using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class Application : IApplication
    {
        public Application(IMenu menu, ReturnData returnData, DummyData dummyData, IAnimalService animalService, ICustomerService customerService, IRecieptService recieptService)
        {
            this.menu = menu;            
            this.returnData = returnData;
            this.dummyData = dummyData;
            this.animalService = animalService;
            this.customerService = customerService;
            this.recieptService = recieptService;
        }

        public IMenu menu { get; set; }        
        public ReturnData returnData { get; set; }
        public DummyData dummyData { get; set; }
        public IAnimalService animalService { get; set; }
        public ICustomerService customerService { get; set; }
        public IRecieptService recieptService { get; set; }
       

        public void Run()
        {
            List<ICustomer> customerList = new();
            customerList = dummyData.PopulateDummyDataCustomer(customerList);

            List<IAnimal> animalList = new();
            animalList = dummyData.PopulateDummyDataAnimal(animalList);

            List<IAnimalExtraServices> serviceList = new();
            serviceList = dummyData.PopulateDummyDataServices(serviceList);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            bool MainMenu()
            {
                menu.MenuItems();

                switch (Console.ReadLine())
                {
                    case "1":
                        //Register a customer
                        customerService.RegisterCustomer(customerList);
                        return true;

                    case "2":
                        //Register a animal
                        animalService.RegisterAnimal(animalList);
                        return true;

                    case "3":
                        //Show all customers
                        returnData.ReturnCustomerData(customerList);
                        return true;

                    case "4":
                        //Show all animals
                        returnData.ReturnAnimalData(animalList);
                        return true;

                    case "5":
                        //Binds a customer to a animal
                        customerService.ConnectCustomerToAnimal(animalList,customerList);
                        return true;
                    case "6":
                        //Check in animal
                        animalService.CheckInAnimal(animalList);
                        return true;
                    case "7":
                        //Check out animal
                        animalService.CheckOutAnimal(animalList);
                        return true;
                    case "8":
                        //Shows a list of all checked in animals
                        returnData.ReturnAnimalDataCheckedInStatus(animalList);
                        return true;
                    case "9":
                        //Add a extra service to a animal
                        animalService.AddServicesToAnimal(serviceList, animalList);
                        return true;
                    case "10":
                        //Get reciept for checked out animal
                        recieptService.GetAllReciepts(customerList);
                        return true;
                    case "11":
                        return false;
                    default:
                        return true;
                }
            }
        }

        
    }
}
