using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrustructures.Data.Context;

namespace OnlineStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineStoreContext _context;
        public HomeController(OnlineStoreContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }
    }
}