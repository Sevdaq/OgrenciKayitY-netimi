using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Ogretmen : BaseEntity<int>
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
        public int TelNo { get; set; }
        public string? FotoPath { get; set; }

        public ICollection<Ogrenci1> Ogrenciler { get; set; }

    }
}
