using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.Server.Data;

namespace TMS.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StationsController : ControllerBase
{
    private readonly TransitDbContext _context;

    public StationsController(TransitDbContext context)
    {
        _context = context;
    }


    [HttpGet("line/{lineId}")]
    public async Task<IActionResult> GetStationsByLine(int lineId)
    {
        var stations = await _context.Stations
            .Include(s => s.RailLine)
            .Where(s => s.RailLineId == lineId)
            .OrderBy(s => s.SequenceNumber)
            .ToListAsync();

        return Ok(stations);
    }
}