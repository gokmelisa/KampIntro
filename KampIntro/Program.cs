using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butuonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butuonu");
            }
            else
            {
                Console.WriteLine("eşittir butuonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine("kategoriEtiketi");
        }
    }
}
