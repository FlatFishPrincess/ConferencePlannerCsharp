using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakersController : ControllerBase
    {
        private readonly BackEndContext _context;

        public SpeakersController(BackEndContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ConferenceDTO.SpeakerResponse>>> GetSpeakers()
        {
            var speakerResponse = await _context.Speakers.AsNoTracking()
                                    .Include(s => s.SessionSpeakers)
                                        .ThenInclude(ss => ss.Session)
                                    .Select(s => s.MapSpeakerResponse())
                                    .ToListAsync();
            return speakerResponse;
        }


        // GET: api/Speakers
        //[HttpGet]
        //public async Task<ActionResult<List<ConferenceDTO.SpeakerResponse>>> GetSpeakers()
        //{
        //    var speakerResponse = await _context.Speakers.AsNoTracking()
        //                            .Include(s => s.SessionSpeakers)
        //                                .ThenInclude(ss => ss.Session)
        //                            .Select(s => s.MapSpeakerResponse())
        //                            .ToListAsync();
        //    return speakerResponse;
        //}

        // GET: api/Speakers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ConferenceDTO.SpeakerResponse>> GetSpeaker(int id)
        //{
        //    var speakerResponse = await _context.Speakers
        //                            .Include(s => s.SessionSpeakers)
        //                                .ThenInclude(s => s.Session)
        //                                .FirstOrDefaultAsync(s => s.Id == id);

        //    if (speakerResponse == null)
        //    {
        //        return NotFound();
        //    }

        //    var speaker = speakerResponse.MapSpeakerResponse();

        //    return speaker;
        //}

    }
}
