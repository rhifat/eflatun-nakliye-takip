using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace EflatunNakliyeTakip.EntityFrameworkCore
{
    public static class EflatunNakliyeTakipDbContextModelCreatingExtensions
    {
        public static void ConfigureEflatunNakliyeTakip(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */
            
            builder.Entity<Gider>(b =>
            {
                b.ToTable(EflatunNakliyeTakipConsts.DbTablePrefix + "Giderler", EflatunNakliyeTakipConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Vasita).IsRequired().HasMaxLength(128);
            });

            builder.Entity<Gelir>(b =>
            {
                b.ToTable(EflatunNakliyeTakipConsts.DbTablePrefix + "Gelirler", EflatunNakliyeTakipConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Vasita).IsRequired().HasMaxLength(128);
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}