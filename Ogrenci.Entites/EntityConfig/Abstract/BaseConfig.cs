using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Abstract;

namespace Ogrenci.Entites.EntityConfig.Abstract
{
    public abstract class BaseConfig<T, TId> : IEntityTypeConfiguration<T> where T : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OzelKod).HasMaxLength(50);
            builder.Property(p => p.CreateDate).HasDefaultValue((DateTime.UtcNow).AddHours(3));
        }
    }
}
