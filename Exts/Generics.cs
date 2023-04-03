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
    }
}