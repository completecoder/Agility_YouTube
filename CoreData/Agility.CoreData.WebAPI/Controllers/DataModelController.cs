using System.Web.Http;
using Agility.Core.Contracts;
using Agility.CoreData.Models;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class DataModelController : BaseController<DataModel>
    {

        public DataModelController(IRepository<DataModel> repository) : base(repository)

        {

        }

    }
}
