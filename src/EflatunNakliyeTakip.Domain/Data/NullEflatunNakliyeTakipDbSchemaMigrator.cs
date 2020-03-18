using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EflatunNakliyeTakip.Data
{
    /* This is used if database provider does't define
     * IEflatunNakliyeTakipDbSchemaMigrator implementation.
     */
    public class NullEflatunNakliyeTakipDbSchemaMigrator : IEflatunNakliyeTakipDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}