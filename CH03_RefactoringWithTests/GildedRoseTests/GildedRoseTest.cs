using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRoseKata.GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("foo", items[0].Name);
        }

        [Fact]
        public void UpdateQuality_NormalItem_DecreasesQualityByOne()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Normal Item", SellIn = 10, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(19, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_AgedBrie_MaxQuality50()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(50, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_BackstagePasses_IncreasesQualityByTwo_When10DaysOrLess()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(22, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_BackstagePasses_IncreasesQualityByThree_When5DaysOrLess()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(23, items[0].Quality);
            Assert.Equal(4, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_BackstagePasses_DropsToZero_AfterConcert()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(0, items[0].Quality);
            Assert.Equal(-1, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_Sulfuras_DoesNotChange()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(80, items[0].Quality);
            Assert.Equal(5, items[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_ConjuredItem_DecreasesQualityByTwo()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(items);

            app.UpdateQuality();

            Assert.Equal(5, items[0].Quality);
            Assert.Equal(2, items[0].SellIn);
        }
    }
}
