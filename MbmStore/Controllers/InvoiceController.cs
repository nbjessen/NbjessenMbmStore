using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Customers"] = ConstructSortedCustomerList(1);

            var invoices = new List<Invoice>();
            ViewBag.Invoices = invoices;

            return View();
        }
        [HttpPost] 
        public IActionResult Index(int? customer) 
        {
            
            var invoices = new List<Invoice>();
            
            if (customer != null)
            {
                //We now know customer is an int therfore we typecast
                ViewData["Customers"] = ConstructSortedCustomerList((int)customer);
                // select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList();

            }
            ViewBag.Invoices = invoices;
            return View();
        }
        private List<SelectListItem> ConstructSortedCustomerList(int customer)
        {

            // declare the list
            var customers = new List<SelectListItem>();



            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {

                if (invoice.Customer.CustomerId == customer)
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Name,
                        Value = invoice.Customer.CustomerId.ToString(),
                        Selected = true
                    });
                }
                else
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Name,
                        Value = invoice.Customer.CustomerId.ToString()
                    });
                }
            }

            // removes duplicate entries with same ID from a IEnumerable 
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            return customers;

        }
    }
}