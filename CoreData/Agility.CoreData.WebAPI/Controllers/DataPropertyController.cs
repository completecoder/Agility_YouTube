using Agility.Core.Contracts;
using Agility.CoreData.Models;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class DataPropertyController : BaseController<DataProperty>
    {

        public DataPropertyController(IRepository<DataProperty> repository) : base(repository)

        {

        }
    }
}
