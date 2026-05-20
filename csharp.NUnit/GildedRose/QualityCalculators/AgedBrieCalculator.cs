using GildedRoseKata.QualityCalculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityCalculators
{
    public class AgedBrieCalculator : IItemQualityCalculator
    {
        public void Calculate(Item item)
        {
            int quality = item.Quality;
            if (item.Quality < 50) quality++;
            if (item.SellIn < 0) quality++;
            item.Quality = quality > 50 ? 50 : quality;
        }
    }
}
