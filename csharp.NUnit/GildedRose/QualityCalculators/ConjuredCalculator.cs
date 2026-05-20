using GildedRoseKata.QualityCalculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityCalculators
{
    public class ConjuredCalculator : IItemQualityCalculator
    {
        public void Calculate(Item item)
        {
            if (item.Quality < 1) return;
            int quality = item.Quality - 1;
            item.Quality = quality < 0 ? 0 : quality;
        }
    }
}
