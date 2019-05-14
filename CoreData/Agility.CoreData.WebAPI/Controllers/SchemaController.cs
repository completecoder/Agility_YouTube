using Agility.Core.Contracts;
using Agility.CoreData.Models;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class SchemaController : BaseController<Schema>
    {

        public SchemaController(IRepository<Schema> repository) : base(repository)

        {

        }
    }
}
