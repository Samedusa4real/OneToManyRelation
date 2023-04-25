using EternaAgain.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaAgain.Controllers
{
    public class TeamController : Controller
    {
        private readonly EternaDbContext _context;

        public TeamController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var memberData = _context.TeamMembers.Include("Position").ToList();
            return View(memberData);
        }
    }
}
