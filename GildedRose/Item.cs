namespace GildedRose
{
    public class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }
}