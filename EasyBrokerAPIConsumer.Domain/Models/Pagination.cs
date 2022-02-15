using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Models
{
    public class Pagination
    {
        public int limit { get; set; }
        public int page { get; set; }
        public int total { get; set; }
        public string next_page { get; set; }
    }
}
