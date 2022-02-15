using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Models
{
    public class Operation
    {
        public string type { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string formatted_amount { get; set; }
        public string unit { get; set; }
    }
}
