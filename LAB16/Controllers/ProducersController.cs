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
    public class ProducersController : ApiController
    {
        private CarEntities db = new CarEntities();

        // GET: api/Producers
        public IQueryable<Producer> GetProducers()
        {
            return db.Producers;
        }

        // GET: api/Producers/5
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> GetProducer(int id)
        {
            Producer producer = await db.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        // PUT: api/Producers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProducer(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producer.ProducerId)
            {
                return BadRequest();
            }

            db.Entry(producer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
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

        // POST: api/Producers
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> PostProducer(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Producers.Add(producer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = producer.ProducerId }, producer);
        }

        // DELETE: api/Producers/5
        [ResponseType(typeof(Producer))]
        public async Task<IHttpActionResult> DeleteProducer(int id)
        {
            Producer producer = await db.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }

            db.Producers.Remove(producer);
            await db.SaveChangesAsync();

            return Ok(producer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProducerExists(int id)
        {
            return db.Producers.Count(e => e.ProducerId == id) > 0;
        }
    }
}