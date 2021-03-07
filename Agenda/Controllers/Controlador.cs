using Domain.Data;
using Common.Validations;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("v1")]
    public class Controlador : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Contact>>> Get([FromServices] DataContext context)
        {
            try
            {
                var contacts = await context.Contacts.ToListAsync();
                return contacts;
            }
            catch (ArgumentException)
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Contact>> Post(
            [FromServices] DataContext context,
            [FromBody] Contact model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (context.Contacts.Where(x => x.Name == model.Name)
                        .FirstOrDefault() == null)
                    {
                        context.Contacts.Add(model);
                        await context.SaveChangesAsync();
                        return model;
                    }
                    else
                        return BadRequest(ModelState);
                }
                else
                    return BadRequest(ModelState);
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }         
        }

        [HttpDelete]
        [Route("erase")]
        public async Task<ActionResult<Contact>> Delete(
            [FromServices] DataContext context,
            [FromBody] string model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var contt = context.Contacts.Where(x => x.Name == model)
                        .FirstOrDefault();
                    if (contt != null)
                    {
                        context.Contacts.Remove(contt);
                        await context.SaveChangesAsync();
                        return contt;
                    }
                    else
                        return BadRequest(ModelState);
                }
                else
                    return BadRequest(ModelState);
            }
            catch (Exception)
            {
                return BadRequest(ModelState);
            }
            
        }
    }
}
