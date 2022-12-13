using Microsoft.AspNetCore.Mvc;
using consumeWebAPI.Models;
namespace consumeWebAPI.Controllers
{
    public class ProductsHttpController : Controller
    {

        ProductsFromAPI pObj = new ProductsFromAPI();
        public IActionResult HttpProducts()
        {
            ViewBag.products = pObj.GetProducts();
            return View();
        }


        public IActionResult AddProduct()
        {
            ViewBag.resul = "";
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductsFromAPI newProduct)
        {

            ProductsFromAPI newProductObj = new ProductsFromAPI()
            {
                PId = 3001,
                PName = "Kia Seltos",
                PCategory = "SUV",
                PPrice = 2600000,
                PIsInStock = true
            };
            ViewBag.result = pObj.AddNewProduct(newProductObj);
            return View();
        }
    }
}
