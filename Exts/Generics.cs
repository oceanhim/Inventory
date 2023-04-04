using app.Models;
using app.Insatantiables;

namespace app.Utils
{
    public static class Ext{
        public static T Clone<T>(this T item){
            var asStr =  System.Text.Json.JsonSerializer.Serialize(item);
            T ret = System.Text.Json.JsonSerializer.Deserialize<T>(asStr)!;
            return ret;
        }

        public static void Use<T>(this T item, IEntity target) where T : IItem, IConsumable
        {
            foreach(KeyValuePair<Modifiers, int> mod in item.Mods)
            {
                switch (mod.Key) 
                {
                    case Modifiers.Health:
                        target.Health += mod.Value;
                        Console.WriteLine($"{item.Name} changed {target.Name}'s {mod.Key} to {target.Health}");
                        break;
                    case Modifiers.MaxHealth:
                        target.MaxHealth += mod.Value;
                        Console.WriteLine($"{item.Name} changed {target.Name}'s {mod.Key} to {target.MaxHealth}");
                        break;
                }
            }
        }
    }
}