using Agility.Core.Contracts;
using Agility.CoreData.Models;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class ApplicationsController : BaseController<Application>
    {

        public ApplicationsController(IRepository<Application> repository) : base(repository)

        {

        }
    }

}