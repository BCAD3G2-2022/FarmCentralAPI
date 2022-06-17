using FarmCentralMvcFrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmCentralMvcFrontEnd.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MvcProductModel> productList;
            HttpResponseMessage response = Helper.WebApiClient.GetAsync("Api/Products").Result;
            productList = response.Content.ReadAsAsync<IEnumerable<MvcProductModel>>().Result;
            return View(productList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            return View(new MvcProductModel());
        }

        [HttpPost]
        public ActionResult AddOrEdit(MvcProductModel product)
        {
            HttpResponseMessage response = Helper.WebApiClient.PostAsJsonAsync("Api/Product", product).Result;
            TempData["SuccessMessage"] = "Product Saved"; //User Added Successfully Message - see User/Index
            return RedirectToAction("Index");
        }
    }
}
