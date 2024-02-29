using Microsoft.EntityFrameworkCore;
using Ogrenci.Entites.Concrete;
using System.Reflection;

namespace Ogrenci.DAL.EfCoreContext
{
    public class SqlDbcontext : DbContext
    {


        public SqlDbcontext()
        {

        }


        public SqlDbcontext(DbContextOptions<SqlDbcontext> options) : base(options)
        {

        }


        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Not> Notlar { get; set; }
        public DbSet<Ogrenci1> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=OgrenciKayitYonetimi;Trusted_Connection=true;Trust Server Certificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("Ogrenci.Entites"));
        }


    }

}

