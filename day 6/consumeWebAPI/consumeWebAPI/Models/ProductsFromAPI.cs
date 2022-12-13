using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace consumeWebAPI.Models
{
    public class ProductsFromAPI
    {
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PCategory { get; set; }
        public int? PPrice { get; set; }
        public bool? PIsInStock { get; set; }

        List<ProductsFromAPI> pList = new List<ProductsFromAPI>();

        public List<ProductsFromAPI> GetProducts()
        {

            string url = "https://localhost:7006/api/Products";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url);


            if (call.Result.IsSuccessStatusCode)
            {
                var data = call.Result.Content.ReadAsAsync<List<ProductsFromAPI>>();
                data.Wait();
               pList =  data.Result;
                return pList;
            }
            else
            {
                throw new Exception("Could not get data, please contact Admin");
            }

            
        
        }


        public string AddNewProduct(ProductsFromAPI newProduct)
        {
            //hard codeing the product for demo purpose
            //ProductsFromAPI newProductObj = new ProductsFromAPI()
            //{
            //    PId = 3001,
            //    PName = "Kia Seltos",
            //    PCategory = "SUV",
            //    PPrice = 2600000,
            //    PIsInStock = true
            //};

            string url = "https://localhost:7006/api/Products";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var product = JsonSerializer.Serialize(newProduct);
            var requestContent = new StringContent(product, Encoding.UTF8, "application/json");



            var call = client.PostAsync(url, requestContent);

            if (call.Result.IsSuccessStatusCode)
            {
                return "Product Added Successfully";
            }
            throw new Exception(call.Result.ToString());

        }
    }
}

















