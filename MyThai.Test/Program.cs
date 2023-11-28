



using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using MyThai.Models.Business.Services;
using MyThai.Models.Data.Repositories;
using System.Data.Common;

string connectionString = "Data Source=DESKTOP-IFNFMI9;Initial Catalog=MyThaiDB;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;";

DbConnection connection = new SqlConnection(connectionString);

DishCategoryRepository dishCategoryRepository = new DishCategoryRepository(connection);
DishCategoryService dishCategoryService = new DishCategoryService(dishCategoryRepository);

DishRepository dishRepository = new DishRepository(connection);
DishService dishService = new DishService(dishRepository , dishCategoryRepository);

#region Test GetById Dish

var dish = dishService.GetById(1);

Console.WriteLine(dish.Id + dish.Name);

#endregion
