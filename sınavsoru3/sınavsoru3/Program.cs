using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınavsoru3
{
    class ev
    {
        private string il;
        public string İL
        { get { return il; }
            set { il = value.ToUpper(); } }
       private string ilçe;
        public string İLÇE
        {
            get { return ilçe; }
            set { ilçe = value.ToUpper(); }
        }
        private string adres;
        public string adress
        {
            get { return adres; }
            set { adres = value.ToUpper(); }
        }
        private string ısınma;
        public string ısınmaa
        {
            get { return ısınma; }
            set { ısınma=value.ToUpper(); }
        }
        public int katsayisi;
    }
    class satılık : ev
    {
        public int krediçekme;
       
    }
    class kiralık : ev
    {
        public int depozito;
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            satılık satilik = new satılık();
            kiralık kiralik = new kiralık();
            Console.WriteLine("kiralik? - satilik? hangi işlemi yapmak istiyorsunuz?");
            string durum = Console.ReadLine();
            if(durum=="kiralik")
            {
                Console.WriteLine("il,ilçe,adres,ısınma,katsayısı,depozito bilgilerini yazınız");
                kiralik.İL = Console.ReadLine();
                kiralik.İLÇE = Console.ReadLine();
                kiralik.adress = Console.ReadLine();
                kiralik.ısınmaa = Console.ReadLine();
                kiralik.katsayisi = Convert.ToInt32(Console.ReadLine());
                kiralik.depozito= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("il:" + " " + kiralik.İL + " " + "ilçe" + " " + kiralik.İLÇE + " " + "adres" + " " + kiralik.adress + " " + "ısınma:" + " " + kiralik.ısınmaa + " " + "kat sayısı:" + " " + kiralik.katsayisi + " " + "depozito:" + " " + kiralik.depozito);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("il ilçe,adres,ısınma,katsayısı,krediçekme miktarı bilgilerini giriniz");
                satilik.İL = Console.ReadLine();
                satilik.İLÇE= Console.ReadLine();
                satilik.adress= Console.ReadLine();
                satilik.ısınmaa = Console.ReadLine();
                satilik.katsayisi= Convert.ToInt32(Console.ReadLine());
                satilik.krediçekme= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("il:"+ " "+satilik.İL + " "+"ilçe"+" "+satilik.İLÇE+" "+"adres"+" "+satilik.adress+" "+"ısınma:"+" "+satilik.ısınmaa+" "+"kat sayısı:"+" "+satilik.katsayisi+" "+"kredi çekme miktarı:"+" "+satilik.krediçekme );
            }Console.ReadLine();
        }
    }
}
