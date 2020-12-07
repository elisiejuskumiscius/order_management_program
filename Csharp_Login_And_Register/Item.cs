using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Login_And_Register
{
    public class Item
    {
        public string ItemName { get; set; }
        public List<Item> Items { get; set; }

        public override

            string ToString() => $"{ItemName} ";

    }
}
