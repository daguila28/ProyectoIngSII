using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Common
{
    public interface IRepository<T>
    {
        void Agregar(T usuario);

        void Eliminar(T usuario);

        T Obtener(Func<T, bool> condicion);

        IEnumerable<T> ObtenerTodos();

        void Guardar();
        IEnumerable<object> GetAll();
    }
}
