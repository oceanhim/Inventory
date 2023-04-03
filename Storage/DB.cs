using app.Models;
using app.Insatantiables;

namespace app.DB
{
    public static class Collectibles
    {
        private static Dictionary<string, IItem> _items = new Dictionary<string, IItem>()
        {
            {"Apple",new Consumable(ItemTypes.Consumable,"Apple",10.0f,10.0f,10,delegate(IEntity target)
                {
                    target.Health += 10;
                    Console.WriteLine(target.Name + " gained 10 health by eating an Apple!");
                }
            )},
            {"Wooden Sword", new Weapon(ItemTypes.Weapon,"Wooden Sword",5.0f,10.0f,50.0f,5.0f,delegate(IEntity target){})}
        };

        public static IItem GetItem(string name)
        {
            var query = from item in _items
                        where item.Key == name
                        select item.Value;
            return query.First();
        }
    }
}