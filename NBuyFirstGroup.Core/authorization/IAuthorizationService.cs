using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.authorization
{
    //hesabı verilen kullanıcı sistemde etkin mi değil mi kontrol eden sevisisimiz. örneğim kullanıcının bir sayfayı görüntüleme yetkisi var mı yok mu işlemleri için vt bağlanıp kullanıcının yetkisi kontrol edilerek sayfanın görünüp görünmeyeceğine karar vereceğiz. farklı bir sistem üzerinde kullanıcı hesapları tutulabileceğinden veya google facebook vs gibi farklı altyapılar üzerinden yetkilendirme sorgulanabileceğinden ötürü yine async olarak düşünülmüştür.

    //kullanıcı authhenticated olarak işaretlenmiş ise yani oturum açık ise bu servisten yararlanabilir.

    //kullanıcı login olduysa sisteme mailini gönderip yetkilerine bakacağız ona göre karar verilecek yoksa yetkiniz yoktur uyarısını görür.
    public interface IAuthorizationService
    {
        Task<bool> IsAuthorized(string email);
    }
}
