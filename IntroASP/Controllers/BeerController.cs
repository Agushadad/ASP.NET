using IntroASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace IntroASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly ASPNETContext _context;

        public BeerController (ASPNETContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var beers = _context.Beers.Include(x => x.Brand);
            return View(await beers.ToListAsync());
        }
    }
}
