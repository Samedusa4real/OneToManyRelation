using EternaAgain.DAL;
using EternaAgain.Models;
using EternaAgain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EternaAgain.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaDbContext _context;

        public HomeController(EternaDbContext context)
        {
            _context = context;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x=>x.Order).ToList(),
                Features = _context.Features.ToList(),
            };
            return View(model);
        }
    }
}