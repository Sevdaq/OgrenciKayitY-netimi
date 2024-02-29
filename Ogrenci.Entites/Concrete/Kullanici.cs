using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Kullanici : BaseEntity<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Gsm { get; set; }
        public string? Email { get; set; }
        public bool? Cinsiyet { get; set; }
        public string? TcNo { get; set; }
        public string? Password { get; set; }
        public int? RolId { get; set; }
        public Rol Rol { get; set; }
        public virtual ICollection<Ogrenci1> Ogrenciler { get; set; }
    }
}