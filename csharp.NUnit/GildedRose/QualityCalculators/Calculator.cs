using GildedRoseKata.QualityCalculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityCalculators
{
    public static class Calculator
    {
        public static Dictionary<string, IItemQualityCalculator> _calculators = new()
        {
            { "Aged Brie", new AgedBrieCalculator() },
            { "Backstage passes to a TAFKAL80ETC concert", new BackstagePassesCalculator() },
            { "Sulfuras, Hand of Ragnaros", new SulfuraCalculator() },
            { "Generic", new GenericItemCalculator() },

        };

        public static void Calculate(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn -= 1;
            }
            switch (item.Name)
            {
                case "Aged Brie":
                case "Backstage passes to a TAFKAL80ETC concert":
                case "Sulfuras, Hand of Ragnaros":
                    _calculators[item.Name].Calculate(item);
                    break;
                default:
                    _calculators["Generic"].Calculate(item);
                    break;
            }
        }
    }
}
