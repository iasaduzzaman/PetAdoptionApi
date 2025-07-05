using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetAdoptionApi.Controllers
{
    public class PetController : ApiController
    {
        [HttpGet]
        [Route("api/pets")]
        public HttpResponseMessage GetAllPets()
        {
            try
            {
                var data = PetServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/pets/{id}")]
        public HttpResponseMessage GetPet(int id)
        {
            try
            {
                var data = PetServices.Get(id);
                if (data == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "Pet not found." });

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/pets")]
        public HttpResponseMessage CreatePet(PetDTO pet)
        {
            try
            {
                var created = PetServices.Create(pet);
                if (created != null)
                    return Request.CreateResponse(HttpStatusCode.Created, created);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Pet creation failed." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpPut]
        [Route("api/pets/{id}")]
        public HttpResponseMessage UpdatePet(int id, PetDTO pet)
        {
            try
            {
                pet.Id = id;
                var updated = PetServices.Update(pet);

                if (updated != null)
                    return Request.CreateResponse(HttpStatusCode.OK, updated);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Pet update failed." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpDelete]
        [Route("api/pets/{id}")]
        public HttpResponseMessage DeletePet(int id)
        {
            try
            {
                var result = PetServices.Delete(id);
                if (result)
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Pet deleted successfully." });

                return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "Pet not found." });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
