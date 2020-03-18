using System.Threading.Tasks;

namespace EflatunNakliyeTakip.Data
{
    public interface IEflatunNakliyeTakipDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
