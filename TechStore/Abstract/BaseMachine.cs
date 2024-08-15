using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Abstract
{
    internal abstract class BaseMachine
    {
        private DateTime productionDate;
        private string serialNumber;
        private string name;
        private string description;
        private string os;

        public DateTime ProductionDate
        {
            get
            {
                return productionDate;
            }
            set
            {
                productionDate = value;
            }
        }
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }

        }

        public string Os
        {
            get
            {
                return os;
            }
            set
            {
                os = value;
            }
        }

        protected BaseMachine()
        {
            ProductionDate = DateTime.Now;
        }

        public virtual void PrintInfo() 
        {
            Console.WriteLine($"Üretim Tarihi : {productionDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Seri Numarası : {serialNumber}");
            Console.WriteLine($"Ürünün adı : {name}");
            Console.WriteLine($"Ürünün Açıklaması : {description}");
            Console.WriteLine($"Ürünün İşletim Sistemi : {os}");
        }

        public abstract void GetProduct();


    }

    
}
