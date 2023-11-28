using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Id_Categorie { get; set; }
        public bool IsDisabled { get; set; }
    }
}
