using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Services.Application;

namespace OnlineStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerServices _customerServices;
        public HomeController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        public IActionResult Index()
        {
            return View(_customerServices.GetEnumerable());
        }
    }
}