using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThai.Models.Data.Interfaces.CRUD
{
    public interface ICrudRepository<TKey, TEntity> : IReaderRepository<TKey, TEntity>
    {
        TEntity Insert(TEntity data);
        bool Update(TKey id, TEntity data);
        bool Deleted(TKey id);

    }
}
