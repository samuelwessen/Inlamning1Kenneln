using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Inlämning_1_Kenneln.Interfaces;

namespace Inlämning_1_Kenneln.Models
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();

            // Register one by one
            builder.RegisterType<Menu>().As<IMenu>();
            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<Animal>().As<IAnimal>();
            builder.RegisterType<ReturnData>().As<ReturnData>();
            builder.RegisterType<DummyData>().As<DummyData>();
            builder.RegisterType<AnimalService>().As<IAnimalService>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<RecieptService>().As<IRecieptService>();

            return builder.Build();
        }
    }
}
