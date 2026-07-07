using Microsoft.AspNetCore.Mvc;
using TMS.Server.Models;

[ApiController]
[Route("api/[controller]")]
public class TransitDataController : ControllerBase
{
    [HttpGet("stations/{lineId}")]
    public IActionResult GetStationsByLine(int lineId)
    {
        // Example dataset for MRT-3 infrastructure mapping
        if (lineId == 3)
        {
            var mrt3Stations = new List<Station>
            {
                new Station { Id = 101, Name = "North Avenue", RailLineId = 3, SequenceNumber = 1, Latitude = 14.6531, Longitude = 121.0307 },
                new Station { Id = 102, Name = "Quezon Avenue", RailLineId = 3, SequenceNumber = 2, Latitude = 14.6425, Longitude = 121.0379 },
                new Station { Id = 103, Name = "GMA-Kamuning", RailLineId = 3, SequenceNumber = 3, Latitude = 14.6353, Longitude = 121.0433 }
            };
            return Ok(mrt3Stations);
        }

        return NotFound("Line not registered in network configuration.");
    }
}