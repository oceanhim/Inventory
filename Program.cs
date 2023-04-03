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
            Consumable apple = (Consumable)Collectibles.GetItem<Consumable>("Apple");
            
            
            var app3 = new Consumable(ItemTypes.Consumable, "Apple", 10.0f, 10.0f, 10, delegate (IEntity target)
            {
                target.Health += 10;
                Console.WriteLine(target.Name + " gained 10 health by eating an Apple!");
            });
            Player.inventory.Add(app3);

            Player.Consume(apple);
            Player.Consume(app3);
        }
    }
}
