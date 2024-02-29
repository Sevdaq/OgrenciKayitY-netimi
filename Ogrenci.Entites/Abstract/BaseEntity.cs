namespace Ogrenci.Entites.Abstract
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? OzelKod { get; set; }

    }
}
