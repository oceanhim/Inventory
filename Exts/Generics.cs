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

        public static void Use<T>(this T item, IEntity target) where T : IItem
        {
            Console.WriteLine(item.Name + " has been used on " + target.Name);
            
            foreach(KeyValuePair<string, int> mod in item.Modifiers)
            {
                
            }
        }
    }
}