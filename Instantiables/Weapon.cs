using app.Models;

namespace app.Insatantiables
{
    public class Weapon : Item, IWeapon
    {
        public float Durability { get;set; }
        public float Damage { get;set; }

        public Weapon(ItemTypes type, string name, float weight, float value, float durability, float damage, Dictionary<string, int> mods) : base(type, name, weight, value, mods)
        {
            Durability = durability;
            Damage = damage;
        }
    }
}