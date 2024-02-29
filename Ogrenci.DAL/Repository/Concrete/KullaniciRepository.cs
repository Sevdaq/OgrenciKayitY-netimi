using Ogrenci.DAL.EfCoreContext;
using Ogrenci.DAL.Repository.Abstract;
using Ogrenci.Entites.Concrete;
using System.Linq.Expressions;

namespace Ogrenci.DAL.Repository.Concrete
{
    public class KullaniciRepository : RepositoryBase<Kullanici, int, SqlDbcontext>, IKullaniciRepository
    {
        public Task<int> Delete(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Kullanici?> Get(Expression<Func<Kullanici, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Kullanici>?> GetAll(Expression<Func<Kullanici, bool>>? expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Kullanici>> GetAllInclude(Expression<Func<Kullanici, bool>>? expression = null, params Expression<Func<Kullanici, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public Task<Kullanici> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Insert(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Kullanici entity)
        {
            throw new NotImplementedException();
        }
    }
}
