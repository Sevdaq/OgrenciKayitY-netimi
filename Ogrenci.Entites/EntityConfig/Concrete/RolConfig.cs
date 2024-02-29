using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ogrenci.Entites.Concrete;
using Ogrenci.Entites.EntityConfig.Abstract;

namespace Ogrenci.Entites.EntityConfig.Concrete
{
    public class RolConfig : BaseConfig<Rol, int>
    {
        public override void Configure(EntityTypeBuilder<Rol> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.RolAdi).HasMaxLength(50);

        }
    }
}
