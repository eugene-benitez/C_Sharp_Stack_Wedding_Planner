using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using Wedding_Planner.Models;
using Microsoft.AspNetCore.Identity;

namespace Wedding_Planner.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        //!!!!!!!!!!!  GET
        //!!!!!!!!!!!  GET
        //!!!!!!!!!!!  GET
        //!!!!!!!!!!!  GET
        //!!!!!!!!!!!  GET

        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Now = CurrentTime;
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("LoggedUser") == null)
            {
                return RedirectToAction("Login");
            }
            List<Wedding> AllWeddings = dbContext.Wedding
            .Include(wedding => wedding.RSVP_Wedding)
            .ThenInclude(guest => guest.User)
            .ToList();
            @ViewBag.AllWeddings = AllWeddings;


            int? id = HttpContext.Session.GetInt32("LoggedUser");
            @ViewBag.UserId = (int)id;


            List<Wedding> Weddings = dbContext.Wedding
            .ToList();

            foreach (var w in Weddings)
            {
                if (w.Date < DateTime.Now)
                {
                    Wedding delWedding =
                    dbContext.Wedding.FirstOrDefault(dish => dish.WeddingId == w.WeddingId);
                    dbContext.Wedding.Remove(delWedding);
                    dbContext.SaveChanges();
                }
            }

            return View();
        }


        [HttpGet("new")]
        public IActionResult NewWedding()
        {
            return View();
        }


        [HttpGet("wedding/{id}")]
        public IActionResult WeddingProfile(int id)
        {
            Wedding retWedding =
            dbContext.Wedding.FirstOrDefault(dish => dish.WeddingId == id);
            @ViewBag.retWedding = retWedding;

            var myWedding =
            dbContext.Wedding
            .Include(c => c.RSVP_Wedding)
            .ThenInclude(rs => rs.User)
            .FirstOrDefault(w => w.WeddingId == id);


            System.Console.WriteLine(myWedding);




            @ViewBag.myWedding = myWedding;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS
        //!!!!!!!!!!!  POSTS

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(User NewUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.User.Any(u => u.Email == NewUser.Email))
                {

                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index");
                }

                // Initializing a PasswordHasher object, providing our User class as its
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                //Save your user object to the database
                dbContext.Add(NewUser);
                // OR dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                // Other code
                return RedirectToAction("Login");
            }

            DateTime CurrentTime = DateTime.Now;
            ViewBag.Now = CurrentTime;
            return View("Index");
        }

        [HttpPost("log")]
        public IActionResult Log(LoginUser submission)
        {
            var userInDb = dbContext.User.FirstOrDefault(u => u.Email == submission.Email);
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(submission, userInDb.Password, submission.Password);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
            }
            HttpContext.Session.SetInt32("LoggedUser", userInDb.UserId);
            return RedirectToAction("Dashboard");
        }


        [HttpPost]
        [Route("create")]
        public IActionResult Create(Wedding NewWedding)
        {
            DateTime CurrentTime = DateTime.Now;
            DateTime Wedding = NewWedding.Date;

            if (ModelState.IsValid)
            {
                if (Wedding < CurrentTime)
                {
                    @ViewBag.Error = "Date must be in the future.";
                    return View("NewWedding");
                }
                int? id = HttpContext.Session.GetInt32("LoggedUser");
                NewWedding.CreatorId = (int)id;
                dbContext.Add(NewWedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            ViewBag.Now = CurrentTime;
            return RedirectToAction("Index");
        }

        [HttpPost("RSVP")]
        public IActionResult RSVP(RSVP newRSVP)
        {
            int? id = HttpContext.Session.GetInt32("LoggedUser");
            newRSVP.UserId = (int)id;
            dbContext.Add(newRSVP);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }




        [HttpGet("delete/{id}")]
        public IActionResult delete(int id)
        {
            Wedding delWedding =
            dbContext.Wedding.FirstOrDefault(dish => dish.WeddingId == id);
            dbContext.Wedding.Remove(delWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpGet("decline/{id}")]
        public IActionResult decline(int id)
        {
            User CurrentUser = dbContext.User
            .SingleOrDefault(user => user.UserId == HttpContext.Session.GetInt32("LoggedUser"));


            RSVP currRSVP = dbContext.RSVP
            .SingleOrDefault(rsvp => rsvp.UserId == HttpContext.Session.GetInt32("LoggedUser") && rsvp.WeddingId == id);

            Wedding currWedding =
            dbContext.Wedding
            .Include(wedding => wedding.RSVP_Wedding)
            .ThenInclude(guest => guest.User)
            .FirstOrDefault(dish => dish.WeddingId == id);
            
            currWedding.RSVP_Wedding.Remove(currRSVP);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }




    }
}
