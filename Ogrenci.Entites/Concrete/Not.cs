using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.Concrete
{
    public class Not : BaseEntity<int>
    {
        public int OgrenciId { get; set; }
        public int DersId { get; set; }
        public decimal NotDegeri { get; set; }

        // ForeignKeyAttribute ile öğrenci ve ders ilişkileri belirtilebilir
        //[ForeignKey("OgrenciId")]
        public virtual Ogrenci1 Ogrenci { get; set; }

        //[ForeignKey("DersId")]
        public virtual Ders Ders { get; set; }

    }
}
