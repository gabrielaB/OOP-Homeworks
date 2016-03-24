using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
   public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;

        public Laptop(string model,decimal price) : this(model,price,null)
        {

        }
        public Laptop(string model,decimal price,string manufacturer) : this(model,price,manufacturer,null)
        {
                
        }
        public Laptop(string model, decimal price, string manufacturer,string processor)
            : this(model,price,manufacturer,processor,0)
        {
                
        }
        public Laptop(string model, decimal price, string manufacturer, string processor,int ram)
            : this(model,price,manufacturer,processor,ram,null)
        {

        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram,string graphicsCard)
            : this(model,price,manufacturer,processor,ram,graphicsCard,0)
        {

        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard,int hdd)
            : this(model,price,manufacturer,processor,ram,graphicsCard,hdd,null)
        {

        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard, int hdd,string screen)
            : this(model,price,manufacturer,processor,ram,graphicsCard,hdd,screen,null)
        {
                
        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screen,Battery battery)
            : this(model,price,manufacturer,processor,ram,graphicsCard,hdd,screen,battery,0.0)
        {

        }
        public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screen, Battery battery,double batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }
       

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Value can not be null");
                }
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Value can not be empty");
                }
                this.model = value;


            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("Value can not be empty");
                    }
                }
                this.manufacturer = value;
              }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("Value can not be empty");
                    }
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.ram = value;

            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("Value can not be empty");
                    }
                }
                this.graphicsCard = value;
            }
        }
        public int Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.hdd = value;

            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("Value can not be empty");
                    }
                }
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.batteryLife = value;

            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.price = value;

            }
        }

        public override string ToString()
        {
            var model = "Model: " + this.Model + "\n";
            var manufacturer = this.Manufacturer == null ? "" : "Manufacturer: " + this.Manufacturer + "\n";
            var processor = this.Processor == null ? "" : "Processor: " + this.Processor + "\n";
            var ram = this.Ram == 0 ? "" : "Ram: " + this.Ram + " GB\n";
            var graphicsCard = this.GraphicsCard == null ? "" : "Graphics Card: " + this.GraphicsCard + "\n";
            var hdd = this.Hdd == 0 ? "" : "Hdd: " + this.Hdd + "GB SSD\n";
            var screen = this.Screen == null ? "" : "Screen: " + this.Screen + "\n";
            var battery = this.Battery == null ? "" : "Battery: " + this.Battery.Type + ", " + this.Battery.Cells + "-cells, " + this.Battery.Power + "mAh" +"\n";
            var batteryLife = this.BatteryLife == 0 ? "" : "Battery Life: " + this.BatteryLife + " hours\n";
            
            var price =String.Format("Price: {0:f2} lv.", this.Price);
            string output = model + manufacturer + processor+ram+graphicsCard + hdd + screen + battery + batteryLife +price;
            return output;
        }
    }
}
