using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    interface IOrderList
    {
        Dictionary<string,string> Orders { get; set; }
    }
}
