using MyThai.Tools;
using MyThai.Models.Data.Entities;
using MyThai.Models.Data.Interfaces;
using MyThai.Models.Data.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Repositories
{
    public class DishCategoryRepository: RepositoryBase, IDishCategoryRepository
    {


        public DishCategoryRepository(DbConnection connection) : base(connection) { }
      
        public IEnumerable<DishCategory> GetAll()
        {
            Connection.Open();
            string query = "SELECT * FROM DishCategory";
            return Connection.ExecuteReader(query, EntityMappers.ToDishCategory , parameters: null);

        }

        public DishCategory? GetById(int id)
        {
        
            string query = "SELECT * FROM DishCategory WHERE Id_DishCategory = @Id";

           return Connection.ExecuteReader(query, EntityMappers.ToDishCategory, parameters: new { Id = id }).SingleOrDefault();
        }
    }
}
