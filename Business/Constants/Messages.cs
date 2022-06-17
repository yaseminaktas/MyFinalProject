using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //static olunca new leme yapılmaz.

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductnameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed= "Ürünler listelendi" ;
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied= "yetkiniz yok";
        public static string UserRegistered="Kullanıcı kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string SuccessfulLogin="Başarıyla giriş yapıldı";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string ProductUpdated= "Ürün güncellendi";
    }
}
