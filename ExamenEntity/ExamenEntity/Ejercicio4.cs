using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

// Ejercicio 4
namespace ExamenEntity
{
    class Ejercicio4
    {
        public Pizza pizza;
        public Ejercicio4(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public decimal total
        {
            get
            {
                var benefict = Convert.ToDecimal(ConfigurationManager.AppSettings["benefict"]);

                var countIngredient = pizza.Id_Ingredients;
                if (countIngredient.Count < 1)
                {
                    throw new Exception("Debe ser uno o mas");
                }

                return countIngredient.Sum(c=>c.Price) * benefict;
            }
        }
    }
}
