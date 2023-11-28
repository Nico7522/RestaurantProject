using MyThai.Models.Business.Interfaces;
using MyThai.Models.Business.Mappers;
using MyThai.Models.Business.Models;
using MyThai.Models.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Business.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IDishCategoryRepository _categoryRepository;

        public DishService(IDishRepository dishRepository, IDishCategoryRepository dishCategoryRepository)
        {
            _dishRepository = dishRepository;
            _categoryRepository = dishCategoryRepository;
        }

        public Dish? GetById(int id)
        {
            var dishEntity = _dishRepository.GetById(id);
            if (dishEntity == null)
                return null;

            var dishCategoryEntity = _categoryRepository.GetById(dishEntity.Id_Categorie);
            if (dishCategoryEntity == null)
                return null;

            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                dishEntity.Price = dishEntity.Price - (dishEntity.Price * (decimal)0.1);
            }
            return dishEntity.ToBll(dishCategoryEntity);
        }

        public Dish Insert(Dish dish)
        {
            var dishInserted = _dishRepository.Insert(dish.ToDal());
            var dishCategorie = _categoryRepository.GetById(dishInserted.Id_Categorie);

            if (dishCategorie == null)
                throw new Exception("Error");
      
            return dishInserted.ToBll(dishCategorie);
        }
    }
}
