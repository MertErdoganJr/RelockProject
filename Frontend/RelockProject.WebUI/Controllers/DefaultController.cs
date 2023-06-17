using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RelockProject.EntityLayer.Concrete;
using RelockProject.WebUI.Dtos.AboutDto;
using RelockProject.WebUI.Dtos.ProductDto;
using RelockProject.WebUI.Dtos.SubscribeDto;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RelockProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SubscribePartial(CreateSubscribeDto createSubscribeDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:12589/api/Subscribe", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

