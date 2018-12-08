using ProyectoFinal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.InfraEstructure.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
     public readonly DbContext _dbContext;

        public Repository(DbContext dbcontext)
        {
            _dbContext = dbcontext;

        }

        public void Agregar(T entidad)
        {
            _dbContext.Set<T>().Add(entidad);
        }

        public void Eliminar(T entidad)
        {
            _dbContext.Set<T>().Remove(entidad);
        }

        public IEnumerable<object> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            _dbContext.SaveChanges();
        }

        public T Obtener(Func<T, bool> condicion)
        {
            return _dbContext.Set<T>().FirstOrDefault(condicion);
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
