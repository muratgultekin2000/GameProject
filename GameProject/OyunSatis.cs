using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OyunSatis
    {
        public void OyunSatisYap(IKampanya kampanya,Uye uye,Oyun oyun)
        {
            
            int fiyat=oyun.OyunFiyati-kampanya.Hesapla();
            Console.WriteLine("Sn."+uye.Ad+" "+oyun.OyunAdi+" oyununu "+fiyat+"TL ile Satın aldınız.");
            
        }
        
    }
}
