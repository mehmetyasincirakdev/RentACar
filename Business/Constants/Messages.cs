using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Cars
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar Listelendi";
        public static string CarsListedByColorId = "Renge göre arabalar Listelendi";
        public static string CarsListedByBrandId = "Markaya göre arabalar Listelendi";

        //Brand
        public static string BrandAdded = "Araba eklendi";
        public static string BrandDeleted = "Araba silindi";
        public static string BrandUpdated = "Araba güncellendi";
        public static string BrandListed = "Arabalar Listelendi";
        //Color
        public static string ColorAdded = "Araba eklendi";
        public static string ColorDeleted = "Araba silindi";
        public static string ColorUpdated = "Araba güncellendi";
        public static string ColorListed = "Arabalar Listelendi";
        internal static string CarNameAlreadyExists;

        public static string CarImageAdded { get; internal set; }
        public static string? AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
