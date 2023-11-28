using MyThai.Models.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = MyThai.Models.Business.Models;
using DAL = MyThai.Models.Data.Entities;
namespace MyThai.Models.Business.Mappers
{
    internal static class DishCategoryMapper
    {
        internal static DAL.DishCategory ToDal(this BLL.DishCategory dishCategorie)
        {
            return new DAL.DishCategory()
            {
                Id = dishCategorie.Id,
                Name = dishCategorie.Name,
            };
        }

        internal static BLL.DishCategory ToBll(this DAL.DishCategory dishCategorie )
        {
            return new BLL.DishCategory(dishCategorie.Id, dishCategorie.Name);
        }
    }
}
