using Inlämning_1_Kenneln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_Kenneln.Models
{
    public class CustomerService : ICustomerService
    {      

        public List<ICustomer> RegisterCustomer(List<ICustomer> customers)
        {
            //Register and save a new User to a list   
            {
                var customer = new Customer();
                //Enter firstname and check if input null or whitespace
                Console.Clear();
                Console.WriteLine("Enter your first name");
                var fname = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(fname))
                {
                    Console.WriteLine("Firstname cannot be empty, try again");
                    fname = Console.ReadLine();
                }
                customer.FirstName = fname;

                //Enter lastname and check if input null or whitespace
                Console.Clear();
                Console.WriteLine("Enter your last name");
                var lname = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(lname))
                {
                    Console.WriteLine("Lastname cannot be empty, try again");
                    lname = Console.ReadLine();
                }
                customer.LastName = lname;

                //Check if phonenumber is an int and not null
                Console.Clear();
                Console.WriteLine("Enter your phonenumber");
                var phoneNumberAsString = Console.ReadLine();
                int phoneNumber;
                while (!int.TryParse(phoneNumberAsString, out phoneNumber))
                {
                    Console.WriteLine("Invalid input, please enter a valid phonenumber");
                    phoneNumberAsString = Console.ReadLine();
                }
                customers.Add(customer);
            }
            Console.WriteLine("Customer saved - press any key");
            Console.Read();
            return customers;
        }

        public void ConnectCustomerToAnimal(List<IAnimal> animalList, List<ICustomer> customerList)
        {
            Console.Clear();
            Console.WriteLine("Please pick a customer");

            foreach (var customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}, {customer.LastName}");
            }

            var customerInputAsString = Console.ReadLine();
            int customerInputAsInt;
            while ((!int.TryParse(customerInputAsString, out customerInputAsInt) || (customerInputAsInt > customerList.Count) || (customerInputAsInt < 0)))
            {
                Console.WriteLine($"Please enter a valid number between 1 and {customerList.Count}");
                customerInputAsString = Console.ReadLine();
            }
            var choosenCustomer = customerList[customerInputAsInt - 1];
            Console.Clear();

            Console.WriteLine("Please pick a animal");
            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animal.Name}, {animal.TypeOfAnimal}");
            }
            var animalInputAsString = Console.ReadLine();
            int animalInputAsInt;
            while ((!int.TryParse(animalInputAsString, out animalInputAsInt)) || (animalInputAsInt > animalList.Count) || (animalInputAsInt < 0))
            {
                Console.WriteLine($"Please enter a valid number between 1 and {animalList.Count}");
                animalInputAsString = Console.ReadLine();
            }
            var choosenAnimal = animalList[animalInputAsInt - 1];

            //Sets the choosen customer to the choosen animal
            choosenCustomer.customerAnimals = choosenAnimal;
            Console.Clear();
            Console.WriteLine($"Data saved: {choosenCustomer.FirstName} {choosenCustomer.LastName} is now connected with {choosenAnimal.Name}");
            Console.WriteLine("Press any key to return to main menu");
            Console.Read();
        }
    }    

}
