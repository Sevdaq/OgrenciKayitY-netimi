using Ogrenci.DAL.EfCoreContext;
using Ogrenci.DAL.Repository.Abstract;
using Ogrenci.Entites.Concrete;

namespace Ogrenci.DAL.Repository.Concrete
{
    public class RoleRepository : RepositoryBase<Rol, int, SqlDbcontext>, IRoleRepository
    {
        public RoleRepository()
        {

        }
    }
}
