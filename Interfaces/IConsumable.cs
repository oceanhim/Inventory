

namespace app.Models
{
    public interface IConsumable
    {
        int maxSize { get;set; }
        int amount { get;set; }
        void Use(IEntity target);
    }
}