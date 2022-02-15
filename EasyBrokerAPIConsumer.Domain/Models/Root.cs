using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Models
{
    public class Root
    {
        public Pagination pagination { get; set; }
        public List<Content> content { get; set; }
    }
}
