(100 XP) Gilded rose - Check your knowledge of conditions, loops, properties,...
# Gilded Rose Requirements Specification

![Gilded Rose](https://miro.medium.com/max/800/1*NoIcn06ksMOa-Ydv1UvYEw.jpeg)

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We
would like to have a system in place that updates our inventory for us. 
Your task is to implement all the features to our system so that we can begin selling a new category of items. 
First an introduction to the system:

	- All items have a SellIn value which denotes the number of days we have to sell the item
	- All items have a Quality value which denotes how valuable the item is
	- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

	- Once the sell by date has passed, Quality degrades twice as fast
	- The Quality of an item is never negative
	- "Aged Brie" actually increases in Quality the older it gets
	- The Quality of an item is never more than 50
	- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

	- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything
still works correctly. 

Just for clarification, 

    - an item can never have its Quality increase above 50, however 
    - "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

Implementation of Item class is here:

```csharp
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
```

Here is how items are created and initialized:
```csharp
items = new List<Item>
{
    new Item("+5 Dexterity Vest") {SellIn = 10, Quality = 20},
    new Item("Aged Brie") {SellIn = 2, Quality = 0},
    new Item("Elixir of the Mongoose") {SellIn = 5, Quality = 7},
    new Item("Sulfuras, Hand of Ragnaros") {SellIn = 0, Quality = 80},
    new Item("Backstage passes to a TAFKAL80ETC concert") {SellIn = 15, Quality = 20},
    new Item("Conjured Mana Cake") {SellIn = 3, Quality = 6}
};
```
