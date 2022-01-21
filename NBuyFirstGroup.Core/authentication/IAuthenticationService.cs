using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.authentication
{
    public interface IAuthentication
    {
        //kullanıcının eposta parola ve oturum açık kalsın seçeneğine göre sisteme giriş yapmasını ve oturumun açık kalmasını sağlayan servis
        // bu servis üzerinden sisteme log in olacağız
        Task AuthenticateAsync(string email, string password, bool persistance);

        // task yazmamızın sebebi : bir sistemde oturum açma isteği farklı servisler üzerinden olabilir. yani google facebook gibi. bu durumda başka bir servise uyg içinden bağlandığımız için bir müddet süre geçeceğine asenkron bir iş yapılması daha doğru olacaktır.


        //kullanıcı eğer başarılı bir şekilde giriş yaptıysa IsAuthenticated  true ve user bilgileri dönsün yoksa hata set edelim.
        public abstract class IAuthenticationResult
        {
            public AuthenticationUser User { get; set; }
            public bool IsAuthenticated { get; set; }
            public string ErorrMessage { get; set; } 
        }
    }
}
