using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.application
{
    public interface IApplicationService<in TRequest, out TResponse>
    {
        //uygulama gelen iş isteklerini yakalayıp işlemek için açtığımız service (use-case işmleri)
        //TRequest uygulama gelen iş isteği
        //TResponse uygulamadan çıkan sonuç yani son kullanacıya dönecek olan result

        TResponse OnProcess(TRequest @request);
       
    }
}
