using GildedRoseKata.QualityCalculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityCalculators
{
    internal class GenericItemCalculator : IItemQualityCalculator
    {
        public void Calculate(Item item)
        {
            if (item.Quality > 0) item.Quality -= 1;
        }
    }
}
