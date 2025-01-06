using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        private readonly Dictionary<string, IItemStrategy> _strategies;

        public GildedRose(IList<Item> items)
        {
            _items = items;

            _strategies = new Dictionary<string, IItemStrategy>
            {
                { "Aged Brie", new AgedBrieStrategy() },
                { "Backstage passes to a TAFKAL80ETC concert", new BackstagePassStrategy() },
                { "Sulfuras, Hand of Ragnaros", new SulfurasStrategy() },
            };
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (!_strategies.TryGetValue(item.Name, out var strategy))
                {
                    strategy = new DefaultItemStrategy();
                }

                strategy.Update(item);
            }
        }
    }

    public interface IItemStrategy
    {
        void Update(Item item);
    }

    public class AgedBrieStrategy : IItemStrategy
    {
        public void Update(Item item)
        {
            DecreaseSellIn(item);
            IncreaseQuality(item);

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }
    }

    public class BackstagePassStrategy : IItemStrategy
    {
        public void Update(Item item)
        {
            DecreaseSellIn(item);

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            IncreaseQuality(item);

            if (item.SellIn < 10)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 5)
            {
                IncreaseQuality(item);
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }
    }

    public class SulfurasStrategy : IItemStrategy
    {
        public void Update(Item item)
        {
            
        }
    }

    public class DefaultItemStrategy : IItemStrategy
    {
        public void Update(Item item)
        {
            DecreaseSellIn(item);
            DecreaseQuality(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
            }
        }

        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}
