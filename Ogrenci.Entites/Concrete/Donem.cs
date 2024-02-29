using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Donem : BaseEntity<int>
    {

        public string DönemAdi { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
    }
}
