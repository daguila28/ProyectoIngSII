using System;
using System.Collections.Generic;
using System.Text;
using ProyectoFinal.Domain.Common;

namespace RdAutoparts.InfraEstructure.Common
{
    class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbContext _dbContext;

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
