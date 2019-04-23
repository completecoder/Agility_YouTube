using Agility.Core.Contracts;
using Agility.CoreData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Agility.CoreData.WebAPI.Controllers
{
    public class ApplicationsController : ApiController
    {
        private IRepository<Application> Repository;

        public ApplicationsController(IRepository<Application> repository)

        {

            this.Repository = repository;

        }



        // GET: api/Applications

        [HttpGet]

        public IHttpActionResult GetAll()

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                return Ok(Repository.Collection());

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }

        }



        // GET: api/Applications/5

        [HttpGet]

        public IHttpActionResult Get(string id)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                return Ok(Repository.Find(id));

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }



        }



        // POST: api/Applications

        [HttpPost]

        public IHttpActionResult Post([FromBody]Application newObject)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                Repository.Insert(newObject);

                Repository.Commit();



                return Ok(newObject); //return the object back with the new Id

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }

        }



        [HttpPut]

        public IHttpActionResult Put(Application updatedObject)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                Repository.Update(updatedObject);

                Repository.Commit();

                return Ok(updatedObject);



            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }



        }



        [HttpDelete]

        public IHttpActionResult Delete(string Id)

        {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);



            try

            {

                Repository.Delete(Id);

                Repository.Commit();



                return Ok(true);

            }

            catch (Exception ex)

            {

                return BadRequest(ex.InnerException == null ? ex.Message : ex.InnerException.Message);

            }



        }

    }

}