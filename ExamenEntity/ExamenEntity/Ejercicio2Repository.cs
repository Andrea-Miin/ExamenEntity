using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

// Ejercicio 2
// Repositorio
namespace ExamenEntity
{
    class Ejercicio2Repository : IEjercicio2, IDisposable
    {
        private PizzeriaContext context;

        public Ejercicio2Repository(PizzeriaContext context)
        {
            this.context = context;
        }

        public Pizza GetPizzaByID(int pizzaId)
        {
            return context.Pizza.Find(pizzaId);
        }

        public void InsertPizza(Pizza pizza)
        {
            context.Pizza.Add(pizza);
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            context.Ingredient.Add(ingredient);
        }

        public void DeletePizza(int pizzaId)
        {
            Pizza pizza = context.Pizza.Find(pizzaId);
            context.Pizza.Remove(pizza);
        }

        public void DeleteIngredient(int ingredientId)
        {
            Ingredient ingredient = context.Ingredient.Find(ingredientId);
            context.Ingredient.Remove(ingredient);
        }

        public void UpdatePizza(Pizza pizza)
        {
            context.Entry(pizza).State = EntityState.Modified;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            context.Entry(ingredient).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
