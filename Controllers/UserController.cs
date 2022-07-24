using System.Linq;
using AubReviews.Models;
using Microsoft.AspNetCore.Mvc;
using AubReviews.Data;

namespace AubReviews.Controllers
{
    public class UserController : Controller
    {
        private readonly AubReviewsContext _context;

        public UserController(AubReviewsContext context){
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}