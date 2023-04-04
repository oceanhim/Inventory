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
            Consumable potion = Collectibles.GetItem<Consumable>("Potion of Healing");
            Consumable cloned = potion.Clone<Consumable>();
            Player.inventory.Add(cloned);
            Player.Consume(cloned);
            Player.inventory.List();

        }
    }
}
