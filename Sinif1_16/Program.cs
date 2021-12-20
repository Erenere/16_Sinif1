using System;

namespace Sinif1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ayse";
            calisan1.soyad = "Kara";
            calisan1.no = 2569921;
            calisan1.departman = "Insan Kaynaklari";
            
            calisan1.CalisanBilgileri();
            Console.WriteLine("***************");
            
            Calisan calisan2 = new Calisan();
            calisan2.ad = "Deniz";
            calisan2.soyad = "Arda";
            calisan2.no = 2563931;
            calisan2.departman = "Satin Alma";
            
            calisan2.CalisanBilgileri();
        }

        class Calisan
        {
            public string ad;
            public string soyad;
            public int no;
            public string departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisanin adi: {0}",ad);
                Console.WriteLine("Calisanin soyadi: {0}",soyad);
                Console.WriteLine("Calisanin numarasi: {0}",no);
                Console.WriteLine("Calisanin departmani: {0}",departman);
            }
        }
    }
}