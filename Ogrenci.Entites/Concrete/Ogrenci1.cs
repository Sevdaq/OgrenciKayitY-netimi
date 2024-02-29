using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Ogrenci1 : BaseEntity<int>
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public ICollection<Not> Notlar { get; set; }
        public string? FotoPath { get; set; }
        public ICollection<Ogretmen> Ogretmen { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
    }
}
