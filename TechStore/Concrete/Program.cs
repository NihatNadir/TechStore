using System;
using System.Xml.Linq;
namespace TechStore.Concrete
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Telefon üretmek için '1' basın Bilgisayar üretmek için '2' basın");
            string response = Console.ReadLine();
            if (response == "1")
            {
                Phone newPhone = new Phone();

                Console.WriteLine("Telefonun seri numarasını giriniz.");
                newPhone.SerialNumber = Console.ReadLine();

                Console.WriteLine("Telefonun adını giriniz.");
                newPhone.Name = Console.ReadLine();

                Console.WriteLine("Telefon için açıklama giriniz.");
                newPhone.Description = Console.ReadLine();

                Console.WriteLine("Telefonun işletim sistemini giriniz.");
                newPhone.Os = Console.ReadLine();

                Console.WriteLine("Telefonda TR lisans varsa 'e' yoksa 'h' basın");
                response = Console.ReadLine();

                if (response == "e")
                    newPhone.IsTr = true;

                else
                    newPhone.IsTr = false;                
                newPhone.GetProduct();
            }
            else if (response == "2")
            {
                Pc newPc = new Pc();
                Console.WriteLine("Bilgisayarın Seri Numarasını giriniz.");
                newPc.SerialNumber = Console.ReadLine();

                Console.WriteLine("Bilgisayarın Adını giriniz.");
                newPc.Name = Console.ReadLine();

                Console.WriteLine("Bilgisayarın Açıklamasını giriniz.");
                newPc.Description = Console.ReadLine();

                Console.WriteLine("Bilgisayarın işletim sistemini giriniz.");
                newPc.Os = Console.ReadLine();

                Console.WriteLine("Bilgisayarda Bluetooth varsa 'e' yoksa 'h' basın");
                response = Console.ReadLine();

                if (response == "e")
                    newPc.Bluetooth = true;

                else
                    newPc.Bluetooth = false;                
                newPc.GetProduct();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız.");
                goto start;
            }
            Console.WriteLine("Başka bir ürün üretmek istiyorsanız 'y' çıkış yapmak istiyorsanız 'h' basın");
            response = Console.ReadLine();
            if (response == "y")
                goto start;
            else
                Console.WriteLine("İyi günler dileriz.");
        }
    }
}