using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.Server.Data;
using TMS.Server.Models;
using Microsoft.AspNetCore.Authorization;

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

    [HttpGet]
    public async Task<IActionResult> GetStations()
    {
        var stations = await _context.Stations
            .Include(s => s.RailLine)
            .OrderBy(s => s.RailLineId)
            .ThenBy(s => s.SequenceNumber)
            .ToListAsync();

        return Ok(stations);
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStation(int id)
    {
        var station = await _context.Stations
            .Include(s => s.RailLine)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (station == null)
        {
            return NotFound();
        }

        return Ok(station);
    }

    // CREATE!
    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<IActionResult> CreateStation(Station station)
    {
        _context.Stations.Add(station);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetStation),
            new { id = station.Id },
            station);
    }


    // UPDATE!
    [Authorize(Roles = "Admin")]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStation(int id, Station updatedStation)
    {
        if (id != updatedStation.Id)
        {
            return BadRequest($"URL id {id} does not match station id {updatedStation.Id}");
        }

        var existingStation = await _context.Stations.FindAsync(id);

        if (existingStation == null)
        {
            return NotFound();
        }

        existingStation.Name = updatedStation.Name;
        existingStation.RailLineId = updatedStation.RailLineId;
        existingStation.SequenceNumber = updatedStation.SequenceNumber;
        existingStation.Latitude = updatedStation.Latitude;
        existingStation.Longitude = updatedStation.Longitude;
        existingStation.FirstTrain = updatedStation.FirstTrain;
        existingStation.LastTrain = updatedStation.LastTrain;
        existingStation.Transfer = updatedStation.Transfer;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE!
    [Authorize(Roles = "Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStation(int id)
    {
        var station = await _context.Stations.FindAsync(id);

        if (station == null)
        {
            return NotFound();
        }

        _context.Stations.Remove(station);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}