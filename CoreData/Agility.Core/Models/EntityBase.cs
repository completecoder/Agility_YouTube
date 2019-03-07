using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.Core.Models
{
    public class EntityBase
    {
        public EntityBase() {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
    }
}
