using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.authentication
{
    public class AuthenticationUser
    {
        //kimliği doğrulanmış kullanıcı bilgilerini döndürür.
        // oturumu açan kullanıcı bilgisi eposta bilgisi
        public string Email { get; private set; }
        public string UserName { get; private set; }
        public string AccessToken { get; private set; } // oturum içib kullanılan token değeri
        public DateTime? AccountExpirationDate { get; private set; } // oturum süresi dolarsa tekrar login olması gerekiyor.

        public AuthenticationUser()
        {

        }
         
        public void SetAuthenticationUser(string email, string username , string accessToken, DateTime accountExpirationDate)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("E-posta boş geçilemez.");

            if (!email.Contains("@"))
                throw new Exception("E-posta formatında giriş yapınız.");

            if (string.IsNullOrEmpty(accessToken))
                throw new Exception("AccesToken gerekli.");

            //eğer yanlışlık ile şuandan küçük bir değer seçilmiş ise minimumda 20 dk lık oturum aç

            if (accountExpirationDate <= DateTime.Now)
                accountExpirationDate = DateTime.Now.AddMinutes(20);

            if (string.IsNullOrEmpty(username)) //usernaame boş ise email olarak default ayarla
                username = email.Trim();

            Email = email.Trim();
            UserName = username.Trim();
            AccessToken = accessToken.Trim();
            AccountExpirationDate = accountExpirationDate;
        }

    }
}
