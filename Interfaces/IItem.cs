namespace app.Models
{

    public enum ItemTypes
    {   
        Unset=0,Armor=1,Weapon=2,Consumable=4
    }
    public interface IStackable
    {
        int maxSize { get;set; }
        int amount { get;set; }
    }

    public interface IItem
    {
        string Name { get;set; }
        int Id { get;set; }
        float Weight { get;set; }

        string ToString();
        float Value { get;set; }
        ItemTypes Type { get; }
        Dictionary<string, int> Modifiers { get; }
    }

    public interface IArmor : IItem
    {
        float Defense { get;set; }
    }

    public abstract class Item : IItem
    {
        public string Name { get; set; } = "";
        public int Id { get; set; }
        public float Weight { get; set; }
        public ItemTypes Type { get;set; }
        public float Value { get;set; }
        public Dictionary<string, int> Modifiers { get;set; }

        public override string ToString()
        {
            return $"{Name} is a {Type} which weighs {Weight} lbs and is worth ${Value}. It's Id is: {Id}";
        }

        public Item(){ Modifiers = new Dictionary<string, int>(); }
        public Item(ItemTypes type, string name, float weight, float value, Dictionary<string, int> mods)
        {
            Random rnd = new Random();
            Type = type;
            Name = name;
            Weight = weight;
            Value = value;
            Id = rnd.Next(10000,100000);
            Modifiers = mods;
        }
    }
}