using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejercicio 2
namespace ExamenEntity
{
    public interface IEjercicio2 : IDisposable
    {
        Pizza GetPizzaByID(int pizzaId);
        void InsertPizza(Pizza pizza);
        void InsertIngredient(Ingredient ingredient);
        void DeletePizza(int pizzaId);
        void DeleteIngredient(int ingredientId);
        void UpdatePizza(Pizza pizza);
        void UpdateIngredient(Ingredient ingredient);
        void Save();
    }

}
