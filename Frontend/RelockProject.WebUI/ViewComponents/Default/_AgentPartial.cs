using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RelockProject.WebUI.Dtos.AboutUsHomePageDto;
using RelockProject.WebUI.Dtos.AgentDto;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RelockProject.WebUI.ViewComponents.Default
{
    public class _AgentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AgentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:12589/api/Agent");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAgentDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
