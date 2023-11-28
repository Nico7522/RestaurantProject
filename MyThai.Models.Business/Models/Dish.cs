using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Models
{
    public class Dish
    {
        public int Id { get; init; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public DishCategory Categorie { get; set; } = null!;

        public Dish(string name, string? description, decimal price, DishCategory categorie)
        {
            Name = name;
            Description = description;
            Price = price;
            Categorie = categorie;
        }

        public Dish(int id, string name, string? description, decimal price, DishCategory categorie)
            : this(name, description, price, categorie)
        {
            Id = id;
        }
    }
}
