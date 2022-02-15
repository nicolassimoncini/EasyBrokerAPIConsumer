using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokerAPIConsumer.Domain.Models
{
    public class Content
    {
        public string public_id { get; set; }
        public string title { get; set; }
        public string title_image_full { get; set; }
        public string title_image_thumb { get; set; }
        public string location { get; set; }
        public List<Operation> operations { get; set; }
        public int? bedrooms { get; set; }
        public int? bathrooms { get; set; }
        public int? parking_spaces { get; set; }
        public string property_type { get; set; }
        public double lot_size { get; set; }
        public double construction_size { get; set; }
        public DateTime updated_at { get; set; }
        public string agent { get; set; }
        public bool show_prices { get; set; }
    }
}
