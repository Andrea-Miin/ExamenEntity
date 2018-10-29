using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEntity
{
    static class Ejercicio3
    {
        public static IEnumerable<Pizza> Page<Pizza>(this IEnumerable<Pizza> source, int page, int pageSize)
        {
            pageSize = 15;
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
