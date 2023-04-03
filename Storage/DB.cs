using app.Models;
using app.Insatantiables;

namespace app.DB
{
    public static class Collectibles
    {
        private static Dictionary<string, IItem> _items = new Dictionary<string, IItem>()
        {
            {"Apple",new Consumable(ItemTypes.Consumable,"Apple",10.0f,10.0f,10)},
            {"Wooden Sword", new Weapon(ItemTypes.Weapon,"Wooden Sword",5.0f,10.0f,50.0f,5.0f)}
        };
        public static T GetItem<T>(string name) where T : IItem
        {
            if (_items.ContainsKey(name))
            {
                return (T)_items[name];
            }
            throw new Exception("Item not in inventory");
        }
    }
}