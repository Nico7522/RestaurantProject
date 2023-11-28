using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = MyThai.Models.Business.Models;
using DAL = MyThai.Models.Data.Entities;


namespace MyThai.Models.Business.Mappers
{
    internal static class DishMapper
    {

        internal static DAL.Dish ToDal(this BLL.Dish dish)
        {
            return new DAL.Dish()
            {
                Id = dish.Id,
                Name = dish.Name,
                Description = dish.Description,
                Price = dish.Price,
                IsDisabled = false,
                Id_Categorie = dish.Categorie.Id
            };
        }

        internal static BLL.Dish ToBll(this DAL.Dish dish, DAL.DishCategory dishCategory)
        {
            return new BLL.Dish(dish.Name, dish.Description, dish.Price, dishCategory.ToBll());
        }
    }
}
