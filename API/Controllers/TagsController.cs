using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TagsController : BaseApiController
    {
        private DataContext _context;
        public TagsController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("logtag")]
        public async Task<int> LogTag(EpcTagDto epcTagDto)
        {
            await _context.EpcTags.AddAsync(new Entities.EpcTag()
            {
                Epc = epcTagDto.Epc,
                LastSeenTime = epcTagDto.Lastseentime,
            });
            return _context.SaveChanges();
        }
    }
}