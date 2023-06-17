using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RelockProject.WebUI.Dtos.ProductDto;
using RelockProject.WebUI.Dtos.TestimonialDto;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TestimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:12589/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
