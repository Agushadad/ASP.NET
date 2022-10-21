using IntroASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntroASP.Controllers
{
    public class BrandController : Controller
    {
        private readonly ASPNETContext _context;

        public BrandController(ASPNETContext context) => _context = context;


        public async Task<IActionResult> Index() => View(await _context.Brands.ToListAsync());
    }
}
