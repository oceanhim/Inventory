using app.Models;
using app.Insatantiables;

namespace app.DB
{
    public static class Collectibles
    {
        private static Dictionary<string, IItem> _items = new Dictionary<string, IItem>()
        {
            // ----------------- ( CONSUMABLES ) -----------------

                { "Bread", new Consumable(ItemTypes.Consumable,"Bread",3.0f,7.0f,30,new Dictionary<Modifiers, int>(){{ Modifiers.Health,10 }}) },

                { "Apple", new Consumable(ItemTypes.Consumable,"Apple",2.0f,5.0f,30,new Dictionary<Modifiers, int>(){{ Modifiers.Health,15 }}) },
            
                { "Potion of Healing",new Consumable(ItemTypes.Consumable,"Potion of Healing",2.0f,50.0f,10,new Dictionary<Modifiers, int>(){{ Modifiers.Health,50 }}) },
            
            // ----------------- ( WEAPONS ) -----------------
    
                { "Wooden Sword", new Weapon(ItemTypes.Weapon,"Wooden Sword",10.0f,5.0f,50.0f,5.0f) }
        
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