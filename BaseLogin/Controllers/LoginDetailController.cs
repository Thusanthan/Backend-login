using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BaseLogin.Models;

namespace BaseLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginDetailController : ControllerBase
    {
        private readonly LoginDetailCotext _context;

        public LoginDetailController(LoginDetailCotext context)
        {
            _context = context;
        }

        // GET: api/LoginDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoginDetail>>> GetLogindetails()
        {
            return await _context.Logindetails.ToListAsync();
        }

        // GET: api/LoginDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoginDetail>> GetLoginDetail(string id)
        {
            var loginDetail = await _context.Logindetails.FindAsync(id);

            if (loginDetail == null)
            {
                return NotFound();
            }

            return loginDetail;
        }

        // PUT: api/LoginDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoginDetail(string id, LoginDetail loginDetail)
        {
            if (id != loginDetail.UserName)
            {
                return BadRequest();
            }

            _context.Entry(loginDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LoginDetail
        [HttpPost]
        public async Task<ActionResult<LoginDetail>> PostLoginDetail(LoginDetail loginDetail)
        {


            _context.Logindetails.Add(loginDetail);
            await _context.SaveChangesAsync();

            

            return CreatedAtAction("GetLoginDetail", new { id = loginDetail.UserName }, loginDetail);
        }

        // DELETE: api/LoginDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoginDetail>> DeleteLoginDetail(string id)
        {
            var loginDetail = await _context.Logindetails.FindAsync(id);
            if (loginDetail == null)
            {
                return NotFound();
            }

            _context.Logindetails.Remove(loginDetail);
            await _context.SaveChangesAsync();

            return loginDetail;
        }

        private bool LoginDetailExists(string id)
        {
            return _context.Logindetails.Any(e => e.UserName == id);
        }
    }
}
