using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{

    public class Sinif : BaseEntity<int>
    {

        public string SinifAdi { get; set; }
        public string Aciklama { get; set; }
        public byte? Kapasite { get; set; }

        public ICollection<Ogrenci1> Ogrenciler { get; set; }

    }
}
