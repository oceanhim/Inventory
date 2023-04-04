namespace app.Models
{
    public enum ItemTypes
    {   
        Unset=0,Armor=1,Weapon=2,Consumable=4
    }
    public enum Modifiers
    {
        Health=0,MaxHealth=1
    }
    public interface IStackable
    {
        int maxSize { get;set; }
        int amount { get;set; }
    }
    public interface IArmor : IItem
    {
        float Defense { get;set; }
    }
}