namespace app.Models
{
    public interface IWeapon : IItem
    {
        float Damage { get;set; }
        float Durability { get;set; }
        
        void Use(IEntity target);
    }
}