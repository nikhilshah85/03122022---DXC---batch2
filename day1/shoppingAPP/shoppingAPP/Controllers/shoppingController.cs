using Microsoft.AspNetCore.Mvc;
using shoppingAPP.Models;

namespace shoppingAPP.Controllers
{
    public class shoppingController : Controller
    {

        public IActionResult ProductsList()
        {
            //collect the data from model
            //pass the data to model
            //ViewBag is used to pass data to views


            //this is a bad practice, controller is not suppose to declare the data, it is suppose to take it from Model
            ProductsModel pObj = new ProductsModel(); //this is bad code
                                                      // we will use DI instead
            
            ViewBag.totalProducts = pObj.TotalProducts();
            ViewBag.totalCategories = pObj.TotalCategories();
            ViewBag.seller = pObj.Seller;

            //List<string> categoryList = new List<string>()
            //{
            //    "Cold-Drinks","Electronics","Shoes","Accessories","TShirts","Cap"
            //};

            ViewBag.pCategories = pObj.GetDistinctCategories();

            ViewBag.productList = pObj.GetAllProducts();

            return View(); 
        }

        public IActionResult CustomerList()
        {
            //collect the data from model
            //pass the data to model
            //ViewBag is used to pass data to views
            return View();
        }
        public IActionResult ViewCart()
        {
            //collect the data from model
            //pass the data to model
            //ViewBag is used to pass data to views
            return View();
        }
        public IActionResult OrderHistory()
        {
            //collect the data from model
            //pass the data to model
            //ViewBag is used to pass data to views
            return View();
        }


    }
}
