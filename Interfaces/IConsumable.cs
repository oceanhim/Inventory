

namespace app.Models
{
    public interface IConsumable
    {
        int maxSize { get;set; }
        int amount { get;set; }
        Dictionary<Modifiers,int> Mods { get;set; }
    }
}