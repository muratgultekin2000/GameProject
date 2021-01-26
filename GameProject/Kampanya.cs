using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IKampanya
    {
        int  Hesapla();
    }
    class Kampanyasız : IKampanya
    {
        public int Hesapla()
        {
            return 0;
        }
    }
    class Kampanya1 : IKampanya
    {
        public int Hesapla()
        {
            return 10;
        }
    }
    class Kampanya2 : IKampanya
    {
        public int Hesapla()
        {
            return 15;
        }
    }
    class Kampanya3 : IKampanya
    {
        public int Hesapla()
        {
            return 20;
        }
    }
}
