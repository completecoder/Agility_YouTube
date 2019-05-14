using Agility.Core.Contracts;
using Agility.Core.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Agility.CoreData.WebAPI.Controllers
{
    // <summary>

    /// Base Controller with common endpoints. (Some need to be overridden)

    /// </summary>

    /// <typeparam name="TEntity"></typeparam>

    public class BaseController<TEntity> : ApiController where TEntity : EntityBase

    {

        internal IRepository<TEntity> context;



        public BaseController(IRepository<TEntity> context)

        {

            this.context = context;



        }



        /// <summary>

        /// Return a complete list of the specified model

        /// </summary>

        /// <returns>List<TEntity></returns>

        [HttpGet]

        [SwaggerResponse(HttpStatusCode.OK)]

        public virtual IHttpActionResult GetAll()

        {

            IQueryable<TEntity> results;



            try

            {

                results = context.Collection();

            }

            catch (Exception ex)

            {

                return BadRequest(ex.Message);

            }



            return Ok(results);

        }



        /// <summary>

        /// Returns a sinlge instance of the specified Entity

        /// </summary>

        /// <param name="id"></param>

        /// <returns></returns>

        [HttpGet]

        public virtual IHttpActionResult Get(string id)

        {

            try

            {

                var results = context.Find(id);

                return Ok(results);

            }

            catch (Exception ex)

            {

                return BadRequest(ex.Message);

            }

        }



        /// <summary>

        /// Insert a new entity.

        /// </summary>

        /// <param name="newObject"></param>

        /// <returns>Returns object with Id</returns>

        [HttpPost]

        public virtual IHttpActionResult Post(TEntity newObject)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                if (string.IsNullOrEmpty(newObject.Id))

                    newObject.Id = Guid.NewGuid().ToString();



                context.Insert(newObject);

                context.Commit();

                return Ok(newObject); //return the object back with the new Id

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }

        }



        [HttpPut]

        public virtual IHttpActionResult Put(TEntity updatedObject)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                context.Update(updatedObject);

                context.Commit();

                return Ok(updatedObject);



            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }



        }



        [HttpDelete]

        public virtual IHttpActionResult Delete(string id)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                context.Delete(id);

                context.Commit();

                return Ok(true);

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }



        }

    }
}
