using Agility.Core.Contracts;
using Agility.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.Data.SQLRepository
{
    namespace CompleteCoder.Common.DataPersistence

    {

        /// <summary>

        /// This class is dependant on EntityFramework, so you need to have added this NuGet package to your project.

        /// </summary>

        /// <typeparam name="T"></typeparam>

        public class SQLRepository<T> : IRepository<T> where T : EntityBase

        {



            internal DataContext context;

            internal DbSet<T> dbSet;



            public SQLRepository(DataContext Context)

            {

                this.context = Context;

                this.dbSet = context.Set<T>();

            }



            public IQueryable<T> Collection()

            {

                return dbSet;

            }



            public void Commit()

            {

                context.SaveChanges();

            }



            public void Delete(string Id)

            {

                var t = Find(Id);

                if (context.Entry(t).State == EntityState.Detached)

                    dbSet.Attach(t);



                dbSet.Remove(t);

            }



            public void Update(T t)

            {

                dbSet.Attach(t);

                context.Entry(t).State = EntityState.Modified;

            }



            public T Find(string Id)

            {

                return dbSet.Find(Id);

            }



            public void Insert(T t)

            {

                dbSet.Add(t);

            }





        }

    }
}
