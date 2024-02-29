using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Rol : BaseEntity<int>
    {
        public ICollection<Kullanici> Kullanicilar { get; set; }
        public string RolAdi { get; set; }
    }
}
