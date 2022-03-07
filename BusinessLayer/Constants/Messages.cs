using CoreLayer.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constants
{
    public static class Messages
    {
        public static string BookAdded = "Kitap Eklendi.";
        public static string BookNameInvalid = "Kitap ismi geçersiz.";
        public static string BookDeleted = "Kitap Silindi.";
        public static string BookUpdated = "Kitap Güncellendi.";
        public static string BooksListed = "Kitaplar Listelendi.";
        public static string BookDetails = "Kitap detayları getirildi.";
        public static string GetBook = "Kitap Getirildi.";



        public static string Maintenance = "System in Maintenance !";
        public static string WriterBookCountError = "Yazar kitap sayısı sınırına ulaşıldı.";
        public static string BookAlreadyExist = "Böyle bir kitap mevcuttur.";



        public static string GetWriter = "Yazar Getirildi.";
        public static string GetWriterList = "Yazarlar Listelendi";
        public static string WriterLimitExceded="Yazar sınırına ulaşıldı.";
        public static string AuthorizationDenied ="Olumsuz";
        public static string UserRegistered="Giriş Yapıldı.";
        public static string UserNotFound="Kullanıcı Bulunamadı !";
        public static string PasswordError ="Hatalı Şifre !";
        public static string SuccessfulLogin="Giriş Başarılı !";
        public static string UserAlreadyExists="Kayıtlı Kullanıcı !!!";
        public static string AccessTokenCreated="Token Oluşturuldu";
    }
}
