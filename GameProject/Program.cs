using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı bilgilerini Kaydetmek için UyeManager nesnemi çağırdim.
            UyeManager uye = new UyeManager();
            //Uye nesnem ile kullanıcı bilgilerini aldım.
            Uye uye1 = new Uye() { Id = 1, Ad = "ali", Soyad = "say", DogumYili =new DateTime(1987,1,1), TcNo = "1123456789" };
            Uye uye2 = new Uye() { Id = 1, Ad = "veli", Soyad = "cark", DogumYili = new DateTime(1988, 1, 1), TcNo = "2123456789" };
            Uye uye3 = new Uye() { Id = 1, Ad = "şahin", Soyad = "kurt", DogumYili = new DateTime(1989, 1, 1), TcNo = "3123456789" };
            //Alıdığım kullanıcı bilgisini kaydettim.
            uye.Ekle(uye1);
            uye.Ekle(uye2);
            uye.Ekle(uye3);
            //Kullanıcı bilgilerini güncelledim.
            uye.Guncelle(uye2);
            //oyun kaydı yaptım
            Oyun oyun1 = new Oyun() { Id = 1, OyunAdi = "Pubg Lite", OyunAciklama = "aksiyon", OyunFiyati=123 };
            Oyun oyun2 = new Oyun() { Id = 2, OyunAdi = "Mario", OyunAciklama = "srateji", OyunFiyati = 1 };
            Oyun oyun3 = new Oyun() { Id = 3, OyunAdi = "Cossak", OyunAciklama = "srateji", OyunFiyati = 45 };


            //oyun kampanyaları hesaplama işlemi yapılıyor.
            //Kampanyalar sisteme dahil ediliyor
            IKampanya kampanyasız = new Kampanyasız();
            IKampanya kampanya1 = new Kampanya1();
            IKampanya kampanya2 = new Kampanya2();
            IKampanya kampanya3 = new Kampanya3();
            //Oyun satış işlemi oluşturuluyor.
            OyunSatis oyunSatis = new OyunSatis();
            //oyun satış işlemi kampanyalı-kampanyasız olarak yapılıyor.
            oyunSatis.OyunSatisYap(kampanya1,uye1,oyun3);
        }
    }
}
