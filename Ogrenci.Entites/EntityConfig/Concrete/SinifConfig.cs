using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Concrete;
using Ogrenci.Entites.EntityConfig.Abstract;

namespace Ogrenci.Entites.EntityConfig.Concrete
{
    public class SinifConfig : BaseConfig<Sinif, int>
    {
        public override void Configure(EntityTypeBuilder<Sinif> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SinifAdi).HasMaxLength(50);
            builder.Property(p => p.Aciklama).HasMaxLength(500);

        }

    }
}
