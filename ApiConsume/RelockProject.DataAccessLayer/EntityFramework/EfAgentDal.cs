using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelockProject.DataAccessLayer.Abstract;
using RelockProject.DataAccessLayer.Concrete;
using RelockProject.DataAccessLayer.Repositories;
using RelockProject.EntityLayer.Concrete;

namespace RelockProject.DataAccessLayer.EntityFramework
{
    public class EfAgentDal : GenericRepository<Agent>, IAgentDal
    {
        public EfAgentDal(Context context) : base(context)
        {

        }
    }
}
