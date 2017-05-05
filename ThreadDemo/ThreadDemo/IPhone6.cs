using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    public class Phone6
    {
        private decimal price = 1000;
        public EventHandler<PriceChangedEventArgs> PriceChanged;

        public virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if(price==value) return;
                decimal oldPrice = Price;
                price = value;
                if (PriceChanged != null)
                {
                    OnPriceChanged(new PriceChangedEventArgs(oldPrice,price));
                }
            }
        }
    }
}
