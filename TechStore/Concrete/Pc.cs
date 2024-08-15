using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechStore.Abstract;

namespace TechStore.Concrete
{
    internal class Pc : BaseMachine
    {
        private int _usbNumber;
        private bool _bluetooth;

        public int UsbNumber
        {
            get
            {
                return _usbNumber;
            }
            set
            {
                if (value == 4 || value == 2)
                {
                    _usbNumber = value;
                }
                else
                {
                    _usbNumber = -1;
                }
            }
        }

        public bool Bluetooth { get; set; }

        public Pc()
        {
            ProductionDate = DateTime.Now;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Usb Giriş Sayısı : {UsbNumber}");
            Console.WriteLine(Bluetooth ? "Bluetooth Var" : "Bluetooth Yok");


        }

        public override void GetProduct()
        {
            Console.WriteLine("Ürün başarılı şekilde üretildi");
            Console.WriteLine($"Bilgisayarın Seri Numarası : {SerialNumber}");
            Console.WriteLine($"Bilgisayarın Adı : {Name}");
            Console.WriteLine($"Bilgisayarın Üretim Tarihi : {ProductionDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Bilgisayarın Açıklaması : {Description}");
            Console.WriteLine($"Bilgisayarın İşletim Sistemi : {Os}");
            Console.WriteLine(Bluetooth ? "Bilgisayarda Bluetooth Var" : "Bilgisayarda Bluetooth Yok");
        }

    }
}
