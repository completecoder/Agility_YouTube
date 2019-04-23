using Agility.Core.Models;
using System.Linq;

namespace Agility.Core.Contracts
{
    public interface IRepository<T> where T : EntityBase

    {

        IQueryable<T> Collection();

        void Commit();

        void Delete(string Id);

        T Find(string Id);

        void Insert(T t);

        void Update(T t);

    }
}
