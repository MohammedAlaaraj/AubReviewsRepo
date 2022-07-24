using System.Linq;
using AubReviews.Models;
using Microsoft.AspNetCore.Mvc;
using AubReviews.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace AubReviews.Controllers{


    public class CourseController : Controller
    {
        private readonly AubReviewsContext _context;

        public CourseController(AubReviewsContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Courses.ToListAsync());
        }

        
    }

}