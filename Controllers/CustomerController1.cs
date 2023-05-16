using APICrudClint.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICrudClint.Controllers
{
    public class CustomerController1 : Controller
    {
        private readonly APIgateway apiGateway;
        public CustomerController1(APIgateway apiGateway)
        {
            this.apiGateway = apiGateway;
        }
        public IActionResult Index()
        {
            List<Customer> customers;
            customers = apiGateway.ListCustomers();
            return View(customers);
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
        return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create() {
            Customer customer = new Customer();
            return View(customer);
        }
        public IActionResult Details(int Id) {
        Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(Customer customer)

        {
            return RedirectToAction("index");
        }
    }
}
