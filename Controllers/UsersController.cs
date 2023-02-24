using Bubisanat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bubisanat.Controllers
{
    public class UsersController : Controller
    {
        
        SignInManager<ApplicationUser> _signInManager;

        public UsersController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(_signInManager.UserManager.Users);
        }
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserName,Password,Email,ConfirmPassword,Agreed")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                if (applicationUser.Agreed==true)
                {
                  _signInManager.UserManager.CreateAsync(applicationUser, applicationUser.Password).Wait();

                    return Redirect("~/");
                }
                
            }

            return View(applicationUser);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string userName, string password)
        {
            Microsoft.AspNetCore.Identity.SignInResult identityResult;

            identityResult = _signInManager.PasswordSignInAsync(userName, password, false, false).Result;
            if (identityResult.Succeeded == true)
            {
                return Redirect("~/");
            }

            return View();
        }
    }
}
