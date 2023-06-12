using Microsoft.EntityFrameworkCore.ChangeTracking;
using RelockProject.DataAccessLayer.Abstract;
using RelockProject.DataAccessLayer.Concrete;
using RelockProject.DataAccessLayer.Repositories;
using RelockProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelockProject.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal: GenericRepository<Subscribe>,  ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {

        }
    }
}
