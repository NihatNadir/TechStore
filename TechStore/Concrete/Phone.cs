using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.Abstract;

namespace TechStore.Concrete
{
    internal class Phone : BaseMachine
    {

        private bool isTr;

        public bool IsTr { get; set; }
        public Phone()
        {
            ProductionDate = DateTime.Now;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(IsTr ? "TR Lisans var" : "TR Lisans yok");


        }

        public override void GetProduct()
        {
            Console.WriteLine("Ürün başarılı şekilde üretildi");
            Console.WriteLine($"Telefonun Seri Numarası : {SerialNumber}");
            Console.WriteLine($"Telefonun Adı : {Name}");
            Console.WriteLine($"Telefonun Üretim Tarihi : {ProductionDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Telefonun Açıklaması : {Description}");
            Console.WriteLine($"Telefonun İşletim Sistemi : {Os}");
            Console.WriteLine(IsTr ? "Telefonun TR Lisans var" : "Telefonun TR Lisans yok");

        }
    }
}
