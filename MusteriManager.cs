using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Siralama(Musteri[] musteri)
        {
            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Name + "\n" + musteriler.Surname + "\n" + musteriler.ID);
                Console.WriteLine("----------------------------------------");
            }
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.ID + " " + " Eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + musteri.ID + " " + " Silindi");

        }
    }
}
