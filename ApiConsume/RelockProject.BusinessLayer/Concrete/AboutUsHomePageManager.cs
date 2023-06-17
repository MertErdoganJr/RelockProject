using RelockProject.BusinessLayer.Abstract;
using RelockProject.DataAccessLayer.Abstract;
using RelockProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelockProject.BusinessLayer.Concrete
{
    public class AboutUsHomePageManager : IAboutUsHomePageService
    {
        private readonly IAboutUsHomePageDal _aboutUsHomePageDal;

        public AboutUsHomePageManager(IAboutUsHomePageDal aboutUsHomePageDal)
        {
            _aboutUsHomePageDal = aboutUsHomePageDal;
        }

        public void TDelete(AboutUsHomePage t)
        {
            _aboutUsHomePageDal.Delete(t);
        }

        public AboutUsHomePage TGetById(int id)
        {
            return _aboutUsHomePageDal.GetById(id);
        }

        public List<AboutUsHomePage> TGetList()
        {
            return _aboutUsHomePageDal.GetList();
        }

        public void TInsert(AboutUsHomePage t)
        {
            _aboutUsHomePageDal.Insert(t);
        }

        public void TUpdate(AboutUsHomePage t)
        {
            _aboutUsHomePageDal.Update(t);
        }
    }
}
