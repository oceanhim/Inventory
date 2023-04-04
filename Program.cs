using app.Insatantiables;
using app.Models;
using app.Utils;
using app.DB;

namespace app
{
    class Program
    {
        public static void Main(string[] args)
        {
            Entity Player = new Entity("Ocean",100.0f,100.0f);

            Consumable bread = Collectibles.GetItem<Consumable>("Bread");
            Consumable cloned3 = bread.Clone<Consumable>();
            Player.inventory.Add(cloned3);

            Weapon sword = Collectibles.GetItem<Weapon>("Wooden Sword");
            Weapon cloned2 = sword.Clone<Weapon>();
            Player.inventory.Add(cloned2);

            Player.inventory.List();
            Player.Consume(cloned3);
        }
    }
}
