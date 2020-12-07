using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Login_And_Register
{
    public class Customer

    {
        public string CustName { get; set; }
        public int CustNum { get; set; }

        public override
                string ToString() => $"{CustName}";

    }
}
