using MyThai.Models.Data.Entities;
using MyThai.Models.Data.Interfaces;
using MyThai.Models.Data.Mappers;
using MyThai.Tools;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Repositories
{
    
    public class DishRepository : RepositoryBase, IDishRepository
    {

        public DishRepository(DbConnection connection) : base(connection) { }
        public bool Deleted(int id)
        {
            Connection.Open();
           string query = "DELETE FROM Dish WHERE Id_Dish = @Id_dish";
           int isDeleted = Connection.ExecuteNonQuery(query, parameters: new { Id_Dish = id});
           return isDeleted > 0;
        }

        public IEnumerable<Dish> GetAll()
        {
            Connection.Open();
            string query = "SELECT * FROM Dish WHERE IsActive = 0";
            return Connection.ExecuteReader(query, reader => reader.ToDish(), parameters: null);
        }

        public IEnumerable<Dish> GetByCategory(int categoryId)
        {
            Connection.Open();
            string query = "SELECT * FROM Dish WHERE IsActive = 0 AND Id_Categorie = @Id";
            return Connection.ExecuteReader(query, reader => reader.ToDish(), parameters: new { Id = categoryId });
        }

        public Dish? GetById(int id)
        {
            Connection.Open();
            string query = "SELECT * FROM Dish WHERE IsActive = 0 AND Id_Dish = @Id";
            return Connection.ExecuteReader(query, reader => reader.ToDish(), parameters: new { Id = id }).SingleOrDefault();
        }

        public Dish Insert(Dish data)
        {
            Connection.Open();
            string query = "INSERT INTO Dish ([Name], [Description], Price, Id_Category) OUTPUT inserted.* VALUES (@Name @Description, @Price, @Id_Categorie)";
           return Connection.ExecuteReader(query, reader => reader.ToDish(), parameters: new { data.Name , data.Description, data.Price, data.Id_Categorie }).Single();
        }

        public bool Update(int id, Dish data)
        {
            throw new NotImplementedException();
        }
    }
}
