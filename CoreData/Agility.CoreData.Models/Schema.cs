using Agility.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.CoreData.Models
{
    public class Schema :EntityBase
    {
        public Schema() {
            this.SchemaProperties = new List<SchemaProperty>();
        }

        public string ApplicationId { get; set; }
        public string Name { get; set; }

        public ICollection<SchemaProperty> SchemaProperties { get; set; }
    }
}
