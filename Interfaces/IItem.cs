namespace app.Models
{
    public interface IItem
    {
        string Name { get;set; }
        int Id { get;set; }
        float Weight { get;set; }

        string ToString();
        float Value { get;set; }
        ItemTypes Type { get; }
    }

    public abstract class Item : IItem
    {
        public string Name { get; set; } = "";
        public int Id { get; set; }
        public float Weight { get; set; }
        public ItemTypes Type { get;set; }
        public float Value { get;set; }

        public override string ToString()
        {
            return $"{Name} is a {Type} which weighs {Weight} lbs and is worth ${Value}. It's Id is: {Id}";
        }

        public Item(){}
        public Item(ItemTypes type, string name, float weight, float value)
        {
            Random rnd = new Random();
            Type = type;
            Name = name;
            Weight = weight;
            Value = value;
            Id = rnd.Next(10000,100000);
        }
    }
}