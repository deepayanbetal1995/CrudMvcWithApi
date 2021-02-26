using CrudPracticeMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CrudPracticeMVC.Controllers
{
    public class brandsMVCController : Controller
    {
        public string baseUrl = "http://localhost:52473/api/";
        // GET: brandsMVC
        public async Task<ActionResult> Index()
        {
            List<brandClass> brand = new List<brandClass>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                HttpResponseMessage res = await client.GetAsync("brands");
                if(res.IsSuccessStatusCode)
                {
                    var brandResponse = res.Content.ReadAsStringAsync().Result;
                    brand = JsonConvert.DeserializeObject<List<brandClass>>(brandResponse);
                }
                return View(brand);
            }
                
        }
    }
}