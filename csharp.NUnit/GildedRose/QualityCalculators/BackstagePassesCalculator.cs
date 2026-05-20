using GildedRoseKata.QualityCalculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityCalculators
{
    public class BackstagePassesCalculator : IItemQualityCalculator
    {
        public void Calculate(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            int quality = item.Quality + 1;

            if (item.SellIn <= 10)
            {
                quality++;
            }
            if (item.SellIn <= 5)
            {
                quality++;
            }
            item.Quality = quality > 50 ? 50 : quality;
        }
    }
}
