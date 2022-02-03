using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.logging
{
    public static class LogLevels
    {
        public const string Error = "Error";
        public const string Information = "Information";
        public const string Warning = "Warning";
        public const string Success = "Success";
    }

    // yapılan işlemlere ait kayıtları izleyebilmek için bu servisin log methodunu kullanacağız. message ve logLevel loglama kriktiklik seviyesi
    public interface ILogServices
    {
        void Log(string message);
    }
}
