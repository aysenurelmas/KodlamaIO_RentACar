using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //UserTest();
            CustomerTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { CarId = 1, CustomerId = 1002, RentDate = DateTime.Now }).Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Console.WriteLine(customerManager.Add(new Customer { UserId = 6, CompanyName = "Kodlama.Io" }).Message);
            /*foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }*/
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            //Console.WriteLine(userManager.Add(new User { FirstName = "Ayşenur", LastName = "Elmas", Email = "ayse@gamil.com", Password = "1234456" }).Message);
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.UserId);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}