using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.Name = "Ahmet";
            musteri.Surname = "Aslan";
            musteri.ID = 187794;

            Musteri musteri2 = new Musteri();

            musteri2.Name = "Mehmet";
            musteri2.Surname = "Ali";
            musteri2.ID = 292542;

            Musteri musteri3 = new Musteri();

            musteri3.Name = "Akıl";
            musteri3.Surname = "Kaya";
            musteri3.ID = 321313;

            MusteriManager Yonetim = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3 };
            Yonetim.Siralama(musteriler);
            Yonetim.Ekle(musteri);
            Yonetim.Silme(musteri3);

            Console.ReadLine();
        }
    }
}
