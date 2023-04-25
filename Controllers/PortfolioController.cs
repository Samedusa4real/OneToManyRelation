using EternaAgain.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaAgain.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaDbContext _context;

        public PortfolioController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var portfolioData = _context.Portfolios.Include("Category").ToList();
            return View(portfolioData);
        }
    }
}
