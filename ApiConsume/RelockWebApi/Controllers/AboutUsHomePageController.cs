using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelockProject.BusinessLayer.Abstract;
using RelockProject.EntityLayer.Concrete;

namespace RelockWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsHomePageController : ControllerBase
    {
        private readonly IAboutUsHomePageService _aboutUsHomePageService;

        public AboutUsHomePageController(IAboutUsHomePageService aboutUsHomePageService)
        {
            _aboutUsHomePageService = aboutUsHomePageService;
        }

        [HttpGet]
        public IActionResult AboutUsHomePageList()
        {
            var values = _aboutUsHomePageService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutUsHomePage(AboutUsHomePage aboutUsHomePage)
        {
            _aboutUsHomePageService.TInsert(aboutUsHomePage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAboutUsHomePage(int id)
        {
            var values = _aboutUsHomePageService.TGetById(id);
            _aboutUsHomePageService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAboutUsHomePage(AboutUsHomePage aboutUsHomePage)
        {
            _aboutUsHomePageService.TUpdate(aboutUsHomePage);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutUsHomePage(int id)
        {
            var values = _aboutUsHomePageService.TGetById(id);
            return Ok(values);
        }
    }
}
