namespace app.Models
{
    public interface IEntity
    {
        string Name { get;set; }
        float Health { get;set; }
        float MaxHealth { get;set; }
        Inventory inventory { get;set; }
        void Die();
    }
}