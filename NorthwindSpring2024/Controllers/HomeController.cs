using Microsoft.AspNetCore.Mvc;
using NorthwindSpring2024.Models;
using System.Diagnostics;

namespace NorthwindSpring2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //brings up the homepage
        {
            string message = "Welcome to my Website";
            ViewBag.Message = message; // sends the variable to the listed view
            
            return View();
        }

        public IActionResult Products()
        {
            List<Product> listOfProducts = new List<Product>();

            Product aProduct1 = new Product(1, "Chai", 1, 1, 18.00);
            Product aProduct2 = new Product(2, "Chang", 1, 1, 19.00);
            Product aProduct3 = new Product(3, "Aniseed Syrup", 1, 2, 10.00);
            Product aProduct4 = new Product(4, "Chef Anton's Cajin Seasoning", 2, 2, 22.00);
            Product aProduct5 = new Product(5, "Chef Anton's Gumbo Mix", 2, 2, 21.35);
            

            listOfProducts.Add(aProduct1);
            listOfProducts.Add(aProduct2);
            listOfProducts.Add(aProduct3);
            listOfProducts.Add(aProduct4);
            listOfProducts.Add(aProduct5);

            ViewBag.ListOfProducts = listOfProducts;

            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> listOfEmployees = new List<Employee>();

            Employee aEmployee1 = new Employee(1, "Davis", "Mark", "Sales Representative", "Mr.", "08/31/1982", "10/10/2013", "4123 Country Rd", "Minneapolis", "North", "55411", "United States", "(612)-123-4567", "1", "Good Performance", 1);
            Employee aEmployee2 = new Employee(2, "Fischer", "Shawn", "Secretary", "Mr.", "01/02/2000", "08/20/2020", "192 Main St", "Minneapolis", "North", "55411", "United States", "(612)-234-5678", "1", "Average Performance", 2);
            Employee aEmployee3 = new Employee(3, "Daniels", "Aubrey", "IT Support", "Mrs.", "02/14/1999", "01/20/2021", "342 Broadway St.", "Minneapolis", "South", "55406", "United States", "(612)-345-6789", "1", "Excellent Performance", 3);
            Employee aEmployee4 = new Employee(4, "Mills", "Cassandra", "HR Representative", "Ms.", "11/10/1995", "05/29/2023", "112 Pine Ave.", "Minneapolis", "South", "55406", "United States", "(612)-246-9753", "1", "Poor Performance", 4);
            Employee aEmployee5 = new Employee(5, "O'Neil", "Shane", "Custodian", "Mr.", "07/11/1980", "03/03/2001", "4122 Washington Blvd.", "Minneapolis", "Downtown", "55402", "United States", "(612)-514-2932", "1", "Good Performance", 5);

            listOfEmployees.Add(aEmployee1);
            listOfEmployees.Add(aEmployee2);
            listOfEmployees.Add(aEmployee3);
            listOfEmployees.Add(aEmployee4);
            listOfEmployees.Add(aEmployee5);

            ViewBag.ListOfEmployees = listOfEmployees;

            return View();
        }

        public IActionResult Suppliers()
        {
            List<Supplier> listOfSuppliers = new List<Supplier>();

            Supplier aSupplier1 = new Supplier(1, "Paper Co.", "Mike Smith", "Owner", "516 County Ave.", "Memphis", "1", "37501", "United States", "(901)-123-9876", "(777)-654-1235", "https://PaperCo.com/home/index");
            Supplier aSupplier2 = new Supplier(2, "Stationary Plus", "Carla Owens", "Sales Representative", "123 Adams Dr.", "Phoenix", "2", "85001", "United States", "(602)-0124-4023", "(999)-111-2341", "https://StationaryPlus.org/home/index");
            Supplier aSupplier3 = new Supplier(3, "Network Securities", "Daniel Travis", "IT Manager", "3123 Bakers Ln.", "Seattle", "1", "98101", "United States", "(206)-765-9182", "(443)-143-8263", "https://NetworkSecurities.com/home/index");
            Supplier aSupplier4 = new Supplier(4, "Office Catering", "Francis O'Neil", "Head Chef", "145 Barnes St.", "Nashville", "1", "37011", "United States", "(615)-221-3002", "(453)-223-4123", "https://OfficeCatering.com/home/index");
            Supplier aSupplier5 = new Supplier(5, "Electronic Store", "Erica Flanders", "Manager", "114 Panda Blvd.", "Kansas City", "3", "64030", "united States", "(816)-998-5462", "(663)-531-9573", "https://ElectronicStore.com/home/index");

            listOfSuppliers.Add(aSupplier1);
            listOfSuppliers.Add(aSupplier2);
            listOfSuppliers.Add(aSupplier3);
            listOfSuppliers.Add(aSupplier4);
            listOfSuppliers.Add(aSupplier5);

            ViewBag.ListOfSuppliers = listOfSuppliers;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
