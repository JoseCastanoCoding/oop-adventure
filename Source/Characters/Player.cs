using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Characters
{
    public class Player : Character, IInventory // it inherits from the class Character!
    {

        private readonly IInventory _inventory;
        public Player(string name) : base(name) // the player is giving the character class the name that it requires
        {
            _inventory = new Inventory();
        }

        public int Total => _inventory.Total;

        public string[] InventoryList => _inventory.InventoryList;

        public void Add(Item item)
        {
            _inventory.Add(item);
        }

        public bool Contains(string itemName)
        {
            return _inventory.Contains(itemName);
        }

        public Item? Find(string itemName)
        {
            return _inventory.Find(itemName);
        }

        public Item? Find(string itemName, bool remove)
        {
            return _inventory.Find(itemName, remove);
        }

        public void Remove(Item item)
        {
            _inventory.Remove(item);
        }

        public Item? Take(string itemName)
        {
            return _inventory.Take(itemName);
        }

        public void Use(string itemName, string source)
        {
            _inventory.Use(itemName, source);
        }
    }
}
