using System.Linq;
using app.Models;

namespace app
{
    public class Inventory
    {
        private List<IItem> _cache;
        public void Remove(string name)
        {
            IItem item = GetItem<IItem>(name);
            if(item is IStackable)
            {
                IStackable stacked = (IStackable)item;
                if(stacked.amount > 1)
                {
                    stacked.amount--;
                }
                else
                {
                    _cache.Remove(GetItem<IItem>(name)); 
                }
            }
            else
            {
                _cache.Remove(GetItem<IItem>(name)); 
            }
        }
        public void Add(IItem item)
        {
            if(item is IStackable){ UpdateStack(item); }
            else 
            { 
                _cache.Add(item); Console.WriteLine(item.Name + " Added to your inventory"); 
            }
        }
        public void List(){ Console.WriteLine(_cache.Count + " items in your inventory:\n-----------"); foreach(IItem item in _cache){Console.WriteLine(item.ToString());} }
        public T GetItem<T>(string name) where T : IItem
        {
            IItem itemm = _cache.Find((item) => item.Name == name)!;
            if (itemm != null)
            {
                return (T)_cache[_cache.IndexOf(itemm)];
            }
            throw new Exception("Item not in inventory");
        }
        public void UpdateStack(IItem item)
        {
            var query = from substance in _cache
                        where substance.Name == item.Name
                        select substance;
            if(query.Count() == 0)
            {
                _cache.Add(item); Console.WriteLine(item.Name + " Added to your inventory"); 
                return;
            }
            IStackable piece = (IStackable)query.First();
            if(piece.amount < piece.maxSize)
            {
                piece.amount++;
            }
            else
            {
                _cache.Add(item); Console.WriteLine(item.Name + " Added to your inventory"); 
            }
        }
        public bool Contains(IItem item)
        {
            return _cache.Contains(item);
        }
        public int Count()
        {
            return _cache.Count;
        }
        public void Clear()
        {
            _cache.Clear();
        }
        public Inventory()
        {
            _cache = new List<IItem>();
        }
    }
}