using NBuyFirstGroup.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.data
{
    //abstract  class olan entity den katılım alan bir şeye ancak repository uygulanabilir
    public interface IRepository<TEntity> where TEntity:Entity
    {
        void Add(TEntity entity);
        void Remove(string Id);
        void Update(TEntity entity); 
        IQueryable<Entity> GetQuery();  //linq
        TEntity Find(string Id);
        IQueryable GetSqlRawQuery(string query); // sql
    }
}
