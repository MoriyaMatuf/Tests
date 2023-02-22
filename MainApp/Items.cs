using System;
using System.Collections.Generic;
using System.Text;

namespace MainProg
{
    public class Items
    {
        public Dictionary<string, Item> items;
        public Items()
        {
            items = new Dictionary<string, Item>();
        }
        public void Load()
        {
            items.Add("a", new Item() { Cast = 10, Name = "moriya" });
            items.Add("b", new Item() { Cast = 15, Name = "yafa" });
            items.Add("c", new Item() { Cast = 22, Name = "tehila" });
        }
        public int Clac(string name, int c)
        {
            Item item = items[name];
            return item.Cast * c;
        }
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

    }
}
