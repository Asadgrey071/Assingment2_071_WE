using APICrudClint.Models;
using Newtonsoft.Json;
using System.Net;

namespace APICrudClint
{
    public class APIgateway
    {
        private string url = "https://localhost:7100/swagger/index.html";
        private HttpClient httpClient = new HttpClient();

        public List<Customer> Customer { get; set; }

        public List<Customer>ListCustomer()
        {
        List<Customer> list = new List<Customer>();
            if (url.Trim().Substring(0, 5).ToLower() == "http")
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                HttpResponseMessage responce = httpClient.GetAsync(url).Result;
                if (responce.IsSuccessStatusCode)
                {
                    string result = responce.Content.ReadAsStringAsync().Result;
                    var datacol = JsonConvert.DeserializeObject<List<Customer>>(result);
                    if (datacol != null)
                        Customer = datacol;
                }
                else
                {
                    string result = responce.Content.ReadAsStringAsync().Result;
                    throw new Exception(" ERROR ACCOURED " + result);
                     }
                }
                catch(Exception ex)
            {
                throw new Exception(" ERROR ACCOURED " + ex.Message);
            }
            finally { }
            return Customer;
                    
                }

        internal List<Customer> ListCustomers()
        {
            throw new NotImplementedException();
        }
    }
        
        }
    

