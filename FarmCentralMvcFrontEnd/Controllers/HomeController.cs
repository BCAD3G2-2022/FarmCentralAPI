using FarmCentralMvcFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarmCentralMvcFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        //public ActionResult AddOrEdit(int id = 0)
        //{
        //    return View(new MvcUserModel());
        //}

        [HttpPost]
        public ActionResult SignIn(MvcUserModel user)
        {
            IEnumerable<MvcUserModel> userList;
            HttpResponseMessage response = Helper.WebApiClient.GetAsync("Api/Users").Result;
            userList = response.Content.ReadAsAsync<IEnumerable<MvcUserModel>>().Result;


            foreach(var i in userList)
            {
                if (i.Username == user.Username)
                {
                    //it exists now check password
                    if (i.PasswordHash == user.PasswordHash)
                    {
                        return RedirectToAction("Index", "Product");
                    }
                    //ToDo Error Message Name
                    return NotFound();
                }
            }
            //Todo Error Message Password
            return NotFound();

            //HttpResponseMessage response = Helper.WebApiClient.PostAsJsonAsync("Api/Users", user).Result;
            //TempData["SuccessMessage"] = "User Saved"; //User Added Successfully Message - see User/Index

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}