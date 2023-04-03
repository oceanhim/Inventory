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
            Consumable apple = (Consumable)Collectibles.GetItem("Apple");
            apple.Use(Player);
            Item a2 = apple.Clone();
            Player.inventory.Add(a2);
            Player.inventory.List();
            Consumable apple2 = (Consumable)Player.inventory.GetItem(a2.Name);
            Player.Consume(apple2);
            Player.inventory.List();
            Console.WriteLine();
        }
    }
}
