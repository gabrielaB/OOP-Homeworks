using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
     public class Battery
    {
        private string type;
        private int cells;
        private int power;

        public Battery(string type,int cells,int power)
        {
            this.Type = type;
            this.Cells = cells;
            this.Power = power;
        }
        public string Type
        {
            get
            {
                return this.type;
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
                this.type = value;
                

            }
        }
        public int Cells
        {
            get
            {
                return this.cells;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.cells = value;

            }
        }
        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can not be negative");
                }
                this.power = value;

            }
        }

    }
}
