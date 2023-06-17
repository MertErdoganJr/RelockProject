using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RelockProject.EntityLayer.Concrete;
using RelockProject.WebUI.Dtos.AboutDto;
using RelockProject.WebUI.Dtos.AboutUsHomePageDto;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _BuyerSellerPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BuyerSellerPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:12589/api/AboutUsHomePage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutUsHomePageDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
