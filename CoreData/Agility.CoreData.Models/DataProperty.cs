using Agility.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.CoreData.Models
{
    public class DataProperty : EntityBase
    {
        public string ModelId {get;set;}
        public string SchemaPropertyId { get; set; }
        public string Value { get; set; }
    }
}
