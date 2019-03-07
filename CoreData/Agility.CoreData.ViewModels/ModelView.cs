using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.CoreData.ViewModels
{
    public class ModelView
    {
        public ModelView()
        {
            this.ModelViewProperties = new List<ModelViewProperty>();
        }

        public string ApplicationId { get; set; }
        public string Name { get; set; }

        public ICollection<ModelViewProperty> ModelViewProperties { get; set; }
    }
}
