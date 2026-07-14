using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.Server.Data;

namespace TMS.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RailLinesController : ControllerBase
{
    private readonly TransitDbContext _context;

    public RailLinesController(TransitDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetRailLines()
    {
        var railLines = await _context.RailLines
            .OrderBy(r => r.Id)
            .ToListAsync();

        return Ok(railLines);
    }
}