using app.Models;
using app.Utils;

namespace app.Insatantiables
{
    public class Entity : IEntity
    {
        public void Consume(Consumable item)
        {
            if (inventory.Contains(item))
            {
                item.Use<Consumable>(this);
                inventory.Remove(item.Name);
            }
            else
                throw new Exception("Item not in inv");
        }
        public string Name { get;set; }
        private float _health { get;set; }
        public float Health { get { return _health; }
            set 
            { 
                if(value <= 0)
                {
                    Die();
                }
                else
                {
                    _health = value;
                }
            } 
        }
        public float MaxHealth { get;set; }
        public Inventory inventory { get;set; }
        public void Die()
        {
            _health = 0;
            inventory.Clear();
            Console.WriteLine("You died and lost all your stuff!");
        }

        public Entity(string name, float health, float maxHealth)
        {
            Name = name;
            _health = health;
            MaxHealth = maxHealth;
            inventory = new Inventory(); 
        }
    }
}