using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Concrete;
using Ogrenci.Entites.EntityConfig.Abstract;

namespace Ogrenci.Entites.EntityConfig.Concrete
{
    public class DersConfig : BaseConfig<Ders, int>
    {

        public override void Configure(EntityTypeBuilder<Ders> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.DersAdi).HasMaxLength(50);
            builder.Property(p => p.Aciklama).HasMaxLength(500);

        }

    }
}
