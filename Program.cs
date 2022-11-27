using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> Class
            // System.Collections.Generic
            // T -> object türündedir.
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            
            // Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            // Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            // Liste içerisinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu!");
            
            // Eleman ile index'e erişim
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e çevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Listeyi nasıl temizleriz?
            hayvanlarListesi.Clear();

            // List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyİsim = "Yılaz";
            kullanıcı1.Yaş = 26;
            
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyİsim = "Çalışkan";
            kullanıcı2.Yaş = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyİsim="Arda",
                Yaş=24
            });
            foreach(var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+kullanıcı.Soyİsim);
                Console.WriteLine("Kullanıcı Yaş: "+kullanıcı.Yaş);
            }
            yeniListe.Clear();
        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyİsim;
        private int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int Yaş { get => yaş; set => yaş = value; }
    }
}
