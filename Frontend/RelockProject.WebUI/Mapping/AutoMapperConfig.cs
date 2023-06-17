using AutoMapper;
using RelockProject.EntityLayer.Concrete;
using RelockProject.WebUI.Dtos.AboutDto;
using RelockProject.WebUI.Dtos.AboutUsHomePageDto;
using RelockProject.WebUI.Dtos.LoginDto;
using RelockProject.WebUI.Dtos.RegisterDto;
using RelockProject.WebUI.Dtos.SubscribeDto;

namespace RelockProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutUsHomePageDto, AboutUsHomePage>().ReverseMap();
            CreateMap<UpdateAboutUsHomePageDto, AboutUsHomePage>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
