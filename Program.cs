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
            Item apple = (Item)Collectibles.GetItem("Apple");
            Entity p2 = Player.Clone();
            Item a2 = apple.Clone(); // Not Working
            Console.WriteLine();
        }
    }
}