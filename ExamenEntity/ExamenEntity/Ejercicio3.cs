using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntity
{
    class Ejercicio3
    {
    }

    // Alternativa con LINQ.
    public static class Paging
    {
        public static IEnumerable<Pizza> Page(this IEnumerable<Pizza> source, int page, int pageSize)
        {
            pageSize = 15;
            return source.Take(pageSize);
        }
        public static IQueryable<TSource> Page<TSource>(this IQueryable<TSource> source, int page, int pageSize)
        {
            pageSize = 15;
            return source.Take(pageSize);
        }
    }
}
