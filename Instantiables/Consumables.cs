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
        public Consumable(ItemTypes type, string name, float weight, float value, int stackSize, Dictionary<string, int> mods) : base(type, name, weight, value, mods)
        {
            maxSize = stackSize;
            amount = 1;
        }
        public Consumable():base(ItemTypes.Unset,"",0,0,new Dictionary<string, int>()){}
        public Consumable(params object[] args):base(ItemTypes.Unset,"",0,0,new Dictionary<string, int>()){

        }
    }
}