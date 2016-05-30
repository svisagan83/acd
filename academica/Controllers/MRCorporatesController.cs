using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using academica.Models;
using System.Web.Routing;

namespace academica.Controllers
{
    //[RoutePrefix("api/MRCorporate")]
    //[Authorize]
    public class MRCorporatesController : ApiController
    {
        private kesavakumar_merarankEntities db = new kesavakumar_merarankEntities();

        // GET: api/MRCorporates
        public IQueryable<MRCorporate> GetMRCorporates()
        {
            return db.MRCorporates;
        }

        // GET: api/MRCorporates/5
        //[Route("get/{id}")]
        [ResponseType(typeof(MRCorporate))]
        public IHttpActionResult GetMRCorporate(int id)
        {
            MRCorporate mRCorporate = db.MRCorporates.Find(id);
            if (mRCorporate == null)
            {
                return NotFound();
            }

            return Ok(mRCorporate);
        }

        // PUT: api/MRCorporates/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMRCorporate(int id, MRCorporate mRCorporate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mRCorporate.ID)
            {
                return BadRequest();
            }

            db.Entry(mRCorporate).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MRCorporateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/MRCorporates
        [ResponseType(typeof(MRCorporate))]
        public IHttpActionResult PostMRCorporate(MRCorporate mRCorporate)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            var errors = ModelState.Values.SelectMany(v => v.Errors);

            db.MRCorporates.Add(mRCorporate);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mRCorporate.ID }, mRCorporate);
        }

        // DELETE: api/MRCorporates/5
        [ResponseType(typeof(MRCorporate))]
        public IHttpActionResult DeleteMRCorporate(int id)
        {
            MRCorporate mRCorporate = db.MRCorporates.Find(id);
            if (mRCorporate == null)
            {
                return NotFound();
            }

            db.MRCorporates.Remove(mRCorporate);
            db.SaveChanges();

            return Ok(mRCorporate);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MRCorporateExists(int id)
        {
            return db.MRCorporates.Count(e => e.ID == id) > 0;
        }
    }
}