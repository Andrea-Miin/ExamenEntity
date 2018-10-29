using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

// Ejercicio 1
namespace ExamenEntity
{
    public class EntityBase
    {
        public int Id { get; set; }
    }

    public class Pizza : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Ingredient> Id_Ingredients { get; set; }
    }

    public class Ingredient : EntityBase
    {
        private decimal _price;

        public string Name { get; set; }
        public decimal Price
        {
            get
            {
                var count = ConfigurationManager.AppSettings["benefict"];
                return _price * Convert.ToDecimal(count);
            }
        }

        public ICollection<Pizza> Id_Pizzas { get; set; }
        
    }
}
