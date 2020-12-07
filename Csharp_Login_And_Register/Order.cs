using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Login_And_Register
{
    public class Order

    {
        public int OrderNum { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public override
                 string ToString() => $"{OrderNum}: {string.Join(", ", Items)}: {string.Join(" ", Customers)}";
    }
}
