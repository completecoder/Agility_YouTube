using Agility.Core.Contracts;
using Agility.CoreData.Models;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class SchemaPropertyController : BaseController<SchemaProperty>
    {

        public SchemaPropertyController(IRepository<SchemaProperty> repository) : base(repository)

        {

        }
    }
}
