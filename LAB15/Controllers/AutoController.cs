using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using LAB15.Models;

namespace LAB15.Controllers
{
    public class AutoController : ApiController
    {
        private CarEntities db = new CarEntities();

        // GET: api/Auto
        public IQueryable<Auto> GetAutoes()
        {
            return db.Autoes;
        }

        // GET: api/Auto/5
        [ResponseType(typeof(Auto))]
        public async Task<IHttpActionResult> GetAuto(int id)
        {
            Auto auto = await db.Autoes.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }

            return Ok(auto);
        }

        // PUT: api/Auto/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAuto(int id, Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != auto.AutoId)
            {
                return BadRequest();
            }

            db.Entry(auto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(id))
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

        // POST: api/Auto
        [ResponseType(typeof(Auto))]
        public async Task<IHttpActionResult> PostAuto(Auto auto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Autoes.Add(auto);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = auto.AutoId }, auto);
        }

        // DELETE: api/Auto/5
        [ResponseType(typeof(Auto))]
        public async Task<IHttpActionResult> DeleteAuto(int id)
        {
            Auto auto = await db.Autoes.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }

            db.Autoes.Remove(auto);
            await db.SaveChangesAsync();

            return Ok(auto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutoExists(int id)
        {
            return db.Autoes.Count(e => e.AutoId == id) > 0;
        }
    }
}