using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SsidController : ControllerBase
    {
        private readonly DataContext _context;

        public SsidController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ssids> Get() => _context.ssids.ToList();

        [Route("Whitelist/Add")]
        [HttpPost]
        public IActionResult AddWhiteList(int id )
        {
            var ssid = _context.ssids.Where(x => x.ID == id).FirstOrDefault();
            var whitelistInput = new whitelist();
            whitelistInput.ID = 0;
            whitelistInput.ssid_id= ssid.ID;
           whitelistInput.max_pwr = ssid.pwr;
          whitelistInput.min_pwr = ssid.pwr;
            whitelistInput.auth = ssid.auth;
            whitelistInput.channel = ssid.channel;
            whitelistInput.cipher = ssid.cipher;
            whitelistInput.enc = ssid.enc;

            _context.whitelist.Add(whitelistInput);
            _context.SaveChanges();
            return Ok();
        }
    }
}