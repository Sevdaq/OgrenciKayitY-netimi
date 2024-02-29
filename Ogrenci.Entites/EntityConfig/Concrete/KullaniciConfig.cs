using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Concrete;
using Ogrenci.Entites.EntityConfig.Abstract;

namespace Ogrenci.Entites.EntityConfig.Concrete
{
    public class KullaniciConfig : BaseConfig<Kullanici, int>
    {

        public override void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Ad).HasMaxLength(50);
            builder.Property(x => x.Soyad).HasMaxLength(50);
            builder.Property(x => x.TcNo).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Gsm).HasMaxLength(20);
            builder.Property(x => x.Password).HasMaxLength(50);

        }
    }
}
