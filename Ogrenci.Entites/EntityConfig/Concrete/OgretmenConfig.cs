using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Concrete;
using Ogrenci.Entites.EntityConfig.Abstract;

namespace Ogrenci.Entites.EntityConfig.Concrete
{
    public class OgretmenConfig : BaseConfig<Ogretmen, int>
    {
        public override void Configure(EntityTypeBuilder<Ogretmen> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Ad).HasMaxLength(50);
            builder.Property(p => p.Soyad).HasMaxLength(50);
            builder.Property(p => p.FotoPath).HasMaxLength(1000);

        }

    }
}
