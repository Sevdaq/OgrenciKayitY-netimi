using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Ders : BaseEntity<int>
    {

        public string DersAdi { get; set; }
        public string Aciklama { get; set; }

        public ICollection<Ogretmen> Ogretmenler { get; set; }

    }
}
