using System.Reflection;
using app.Models;

namespace app.Insatantiables
{
    
    public class Consumable : Item, IStackable, IConsumable
    {
        public override string ToString()
        {
            return $"{Name} is a {Type} which weighs {Weight} lbs and is worth ${Value}. Currently {amount}/{maxSize} in stack. It's Id is: {Id}";
        }
        public int maxSize { get;set; }
        public int amount { get;set; }
        public Dictionary<Modifiers, int> Mods { get;set; }
        public Consumable(ItemTypes type, string name, float weight, float value, int stackSize, Dictionary<Modifiers, int> mods) : base(type, name, weight, value)
        {
            maxSize = stackSize;
            amount = 1;
            Mods = mods;
        }
        public Consumable():base(ItemTypes.Unset,"",0,0){Mods = new Dictionary<Modifiers, int>();}
        public Consumable(params object[] args):base(ItemTypes.Unset,"",0,0){
            Mods = new Dictionary<Modifiers, int>();
        }
    }
}