using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.caching
{
    public interface ICacheStore<TModel>
    {
        
        void Set(string cacheKEy, TModel model); // keye göre cacheler
        TModel Get(string cacheKey); //keye göre cacahe getirir.
        void Clear(string cacheKey); // cache temizler
    }
}
