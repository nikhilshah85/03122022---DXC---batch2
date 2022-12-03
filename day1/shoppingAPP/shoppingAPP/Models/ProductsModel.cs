using System.Net;

namespace shoppingAPP.Models
{
    public class ProductsModel
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        public string Seller { get; set; } = "Nikhil Shah";

        static List<ProductsModel> pList = new List<ProductsModel>()
        {

            new ProductsModel() { pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=102, pName="Coke", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=103, pName="Maggie", pCategory="Fast-Food", pIsInStock=false, pPrice=50},
            new ProductsModel() { pId=104, pName="IPhone", pCategory="Electronics", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=105, pName="Nike", pCategory="Shoes", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=106, pName="Ray-Ban", pCategory="Accessories", pIsInStock=false, pPrice=50},
            new ProductsModel() { pId=107, pName="Fossil", pCategory="Electronics", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=108, pName="Dell lattitude", pCategory="Electronics", pIsInStock=false, pPrice=50},
             new ProductsModel() { pId=109, pName="Ray-Ban", pCategory="Accessories", pIsInStock=false, pPrice=50},
            new ProductsModel() { pId=110, pName="Fossil", pCategory="Electronics", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=111, pName="Green-Tea", pCategory="Hot-Beverage", pIsInStock=false, pPrice=50},
        };

        public int TotalProducts()
        {
            return pList.Count;
        }

        public int TotalCategories()
        {
            var totalCategories = (from p in pList
                                   select p.pCategory).Distinct().Count();

            return totalCategories;
        }

        public List<string> GetDistinctCategories()
        {
            var distinctCategories = (from p in pList
                                      select p.pCategory).Distinct().ToList();
            return distinctCategories;
        }

        public List<ProductsModel> GetAllProducts()
        {
            return pList;
        }

    }
}
