using MyThai.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Mappers
{
    internal static class EntityMappers
    {
        internal static DishCategory ToDishCategory(this IDataRecord reader)
        {
            return new DishCategory()
            {
                Id = (int)reader["Id_DishCategory"],
                Name = (string)reader["Name"],
            };
        }

        internal static Dish ToDish(this IDataRecord reader)
        {
            return new Dish()
            {
                Id = (int)reader["Id_Dish"],
                Name = (string)reader["Name"],
                Price = (decimal)reader["Price"],
                Description = reader["Description"] is DBNull ? (string)reader["Description"] : null,
                Id_Categorie = (int)reader["Id_Category"],
                IsDisabled = (bool)reader["IsActive"]
                
            };
        }
    }
}
