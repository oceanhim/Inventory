using app.Models;

namespace app.Insatantiables
{
    public class Weapon : Item, IWeapon
    {
        public float Durability { get;set; }
        public float Damage { get;set; }

        public Weapon(ItemTypes type, string name, float weight, float value, float durability, float damage) : base(type, name, weight, value)
        {
            Durability = durability;
            Damage = damage;
        }
        // public Weapon():base(ItemTypes.Unset,"",0,0){}
        // public Weapon(params object[] args):base(ItemTypes.Unset,"",0,0){

        // }
    }
}