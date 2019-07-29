using System;
using System.Collections.Generic;
using System.Linq;

namespace Horizontalité
{
    class Item {
        public string Name {get;set;}
        public int Value {get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int HorizontalFunction() {
            var items = GetItems();
            return items.Where(it => it.Name.Contains("Unallowed Name")).Where(it=> it.Value < 0).GroupBy(it => it.Name).Max(grp => grp.Max(it => it.Value));
        }

        static int VerticalFunction() {
            var items = GetItems();
            return items
                .Where(it => it.Name.Contains("Unallowed Name"))
                .Where(it=> it.Value < 0)
                .GroupBy(it => it.Name)
                .Max(grp => grp.Max(it => it.Value));
        }

        static private IEnumerable<Item> GetItems() {
            return new Item[0];
        }
    }
}
