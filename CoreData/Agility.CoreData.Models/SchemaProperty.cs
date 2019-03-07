using Agility.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.CoreData.Models
{
    public class SchemaProperty : EntityBase
    {
        public string SchemaId { get; set; }

        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string DataType { get; set; }
    }
}
