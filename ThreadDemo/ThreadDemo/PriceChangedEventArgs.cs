﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    /// <summary>
    /// 事件的标准模式
    /// </summary>
    public class PriceChangedEventArgs:EventArgs
    {
        public readonly decimal OldPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
