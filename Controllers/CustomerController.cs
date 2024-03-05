using Microsoft.AspNetCore.Mvc;
using CRUDMVCWEB.Models;
using CRUDMVCWEB.Data;
using CRUDMVCWEB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVCWEB.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext dbContext;

        public CustomerController(AppDbContext DbContext)
        {
            dbContext = DbContext;
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(CustomerContactViewModel CustomerContactVM)
        {
            Customer customer = new Customer
            {
                CusName = CustomerContactVM.CusName,
                CusEmail = CustomerContactVM.CusEmail,
                CusMessage = CustomerContactVM.CusMessage,
                CusPhone = CustomerContactVM.CusPhone,
                CusAgree = CustomerContactVM.CusAgree,
            };

            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();
            
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var customer = await dbContext.Customers.ToListAsync();
            return View(customer);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var customer = await dbContext.Customers.FindAsync(id);
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Customer viewModel)
        {

            var customer = await dbContext.Customers.FindAsync(viewModel.CusId);
            if(customer is not null)
            {
                customer.CusName = viewModel.CusName;
                customer.CusEmail = viewModel.CusEmail;
                customer.CusPhone  = viewModel.CusPhone;
                customer.CusMessage = viewModel.CusMessage;
                customer.CusAgree = viewModel.CusAgree;
                await dbContext.SaveChangesAsync();
            }
            
            return  RedirectToAction("List","Customer");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Customer viewModel)
        {

            var customer = await dbContext.Customers.FindAsync(viewModel.CusId);
            if (customer is not null)
            {
                dbContext.Customers.Remove(customer);   
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Customer");
        }

    }
}
