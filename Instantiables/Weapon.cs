using app.Models;

namespace app.Insatantiables
{
    public class Weapon : Item, IWeapon
    {
        public float Durability { get;set; }
        public void Use(IEntity target){ target.Health -= Damage; _extra(target); }
        public float Damage { get;set; }
        private Action<IEntity> _extra { get;set; }

        public Weapon(ItemTypes type, string name, float weight, float value, float durability, float damage, Action<IEntity> use) : base(type, name, weight, value)
        {
            _extra = use;
            Durability = durability;
            Damage = damage;
        }
    }
}