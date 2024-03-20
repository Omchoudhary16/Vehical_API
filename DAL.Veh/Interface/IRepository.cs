using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Veh.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> FindById(object id);
        Task Add (TEntity entity);
        Task Update (TEntity entity);
        Task Delete (object id);
        Task SaveChanges();
    }
}
