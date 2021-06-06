using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarListed = "Arabalar listelendi";
        public static string DataUpdated = "Veri güncellendi";
        public static string DataDeleted = "Veri silindi";
        public static string DailyPriceInvalid = "Günlük fiyatı geçersiz";
        public static string DataAdded = "Veri eklendi";
        public static string MaintenanceTime = "Sitemiz şuanda bakımdadır 01:00 saati ile işleminizi gerçekleştirebilirsiniz.";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka listelendi";
        public static string brandUpdate = "Marka güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string RentalNotComeBack = "Araç teslim edilmedi";
        public static string CarNameAlreadyExists = "Böyle bir isim zaten mevcut ";
        public static string ImageLimit = "Bir arabaya 5 ten fazla resim koyulamaz";
        public static string ImageUpdate = "Resim güncellendi";
        public static string ManyCategories;
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered;
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin;
        public static string UserAlreadyExists = "Bu kullanıcı zaten giriş yapmıştı";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
