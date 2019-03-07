using Agility.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.CoreData.Models
{
    public class DataModel : EntityBase
    {
        public DataModel() {
            this.DataProperties = new List<DataProperty>();
        }

        public string SchemaId { get; set; }
        public ICollection<DataProperty> DataProperties { get; set; }
    }
}
