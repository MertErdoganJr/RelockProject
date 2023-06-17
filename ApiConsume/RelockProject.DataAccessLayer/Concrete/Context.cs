using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RelockProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product = RelockProject.EntityLayer.Concrete.Product;

namespace RelockProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JNJNVEQ\\MERTSQL;initial catalog=RelockDb;integrated security=true");
        }
        public DbSet<Product> Products{ get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<AboutUsHomePage> AboutUsHomePages { get; set; }
    }
}
