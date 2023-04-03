using app.Models;
using app.Insatantiables;

namespace app.DB
{
    public static class Collectibles
    {
        private static Dictionary<string, IItem> _items = new Dictionary<string, IItem>()
        {
            {"Apple",new Consumable(ItemTypes.Consumable,"Apple",10.0f,10.0f,10)},
            {"Wooden Sword", new Weapon(ItemTypes.Weapon,"Wooden Sword",5.0f,10.0f,50.0f,5.0f,delegate(IEntity target){})}
        };

        public static IItem GetItem(string name)
        {
            var query = from item in _items
                        where item.Key == name
                        select item.Value;
            return query.First();
        }

        // public static Consumable CreateNewConsumable(string name)
        // {
        //     Consumable item = (Consumable)GetItem(name);
        //     return new Consumable(item.Type,item.Name,item.Weight,item.Value,item.amount);
        // }

        // public static Weapon CreateNewWeapon(string name)
        // {
        //     Weapon item = (Weapon)GetItem(name);
        //     return new Weapon(item.Type,item.Name,item.Weight,item.Value,item.Durability,item.Damage,item.Use);
        // }
    }
}