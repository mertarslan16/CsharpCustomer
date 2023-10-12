using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Linq;
using UdemyProje1.Models;

namespace UdemyProje1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;

            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer) 
        {
            Customer lastCustomer = null;
            if (CustomerContext.Customers.Count > 0) 
            {
                lastCustomer = CustomerContext.Customers.Last();
            }

            customer.Id = 1;
            if (lastCustomer !=null) 
            {
                customer.Id = lastCustomer.Id+1;
            }
            CustomerContext.Customers.Add(customer);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Remove(int id) 
        {
            var removedCostumer = CustomerContext.Customers.Find(x => x.Id == id);   
            CustomerContext.Customers.Remove(removedCostumer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id) 
        { 
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(x => x.Id == id);    
            return View(updatedCustomer);

        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(x=>x.Id == customer.Id); 

            updatedCustomer.FirstName = customer.FirstName;
            updatedCustomer.LastName = customer.LastName;   
            updatedCustomer.Age = customer.Age;

            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var logFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "logs");
            var logFileName = DateTime.Now.ToString();

            logFileName = logFileName.Replace(" ", "_");
            logFileName = logFileName.Replace(":", "-");
            logFileName = logFileName.Replace("/", "-");

            logFileName += ".txt";

            var logFilePath = Path.Combine(logFolderPath, logFileName);

            DirectoryInfo directoryInfo = new DirectoryInfo(logFolderPath);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            FileInfo fileInfo = new FileInfo(logFilePath);
            var writer = fileInfo.CreateText();
            writer.WriteLine("Hatanın gerçekleştiği yer :" + exceptionHandlerPathFeature.Path);

            writer.WriteLine("Hata mesajı :" + exceptionHandlerPathFeature.Error.Message);

            writer.Close();
            return View();
        }
        public IActionResult Hata()
        {
            throw new System.Exception("Sistemsel hata oluştu");
        }


    }
}
