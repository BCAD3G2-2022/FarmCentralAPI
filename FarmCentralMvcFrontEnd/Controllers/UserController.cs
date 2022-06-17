using FarmCentralMvcFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmCentralMvcFrontEnd.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MvcUserModel> userList;
            HttpResponseMessage response =  Helper.WebApiClient.GetAsync("Api/Users").Result;
            userList = response.Content.ReadAsAsync<IEnumerable<MvcUserModel>>().Result;
            //var subList = userList.Select(a => a.MvcUserType == 3);
            return View(userList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            return View(new MvcUserModel());
        }

        [HttpPost]
        public ActionResult AddOrEdit(MvcUserModel user)
        {
            HttpResponseMessage response = Helper.WebApiClient.PostAsJsonAsync("User", user).Result;
            TempData["SuccessMessage"] = "User Saved"; //User Added Successfully Message - see User/Index
            return RedirectToAction("Index");
        }
    }
}
