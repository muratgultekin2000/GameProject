using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UyeManager
    {
        
        public void Ekle(Uye uye)
        {
            UyeKontrolManager uyeKontrolManager = new UyeKontrolManager();
            
            if (uyeKontrolManager.GercekKisiMi(uye))
            {
                Console.WriteLine(uye.Ad + " kaydınız yapılmıştır.");
            }
            else
            {
                Console.WriteLine(uye.Ad + " kaydınız yapılamamıştır!!!");
            }
            
        }

        
        public void Guncelle(Uye uye)
        {
            
            Console.WriteLine(uye.Ad+" bilgilerinizde güncelleme yapılmıştır");
        }
        public void Sil(Uye uye)
        {
            Console.WriteLine("Üyeliğiniz kaldırılmıştır.");
        }
    }
}



   
   


