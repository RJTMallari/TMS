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
                new Station { Id = 103, Name = "GMA-Kamuning", RailLineId = 3, SequenceNumber = 3, Latitude = 14.6353, Longitude = 121.0433 },
                new Station { Id = 104, Name = "Araneta Center-Cubao", RailLineId = 3, SequenceNumber = 4, Latitude = 14.6221, Longitude = 121.0526 },
                new Station { Id = 105, Name = "Santolan-Annas", RailLineId = 3, SequenceNumber = 5, Latitude = 14.6079, Longitude = 121.0564 },
                new Station { Id = 106, Name = "Ortigas", RailLineId = 3, SequenceNumber = 6, Latitude = 14.5878, Longitude = 121.0567 },
                new Station { Id = 107, Name = "Shaw Boulevard", RailLineId = 3, SequenceNumber = 7, Latitude = 14.5812, Longitude = 121.0537 },
                new Station { Id = 108, Name = "Boni", RailLineId = 3, SequenceNumber = 8, Latitude = 14.5739, Longitude = 121.0482 },
                new Station { Id = 109, Name = "Guadalupe", RailLineId = 3, SequenceNumber = 9, Latitude = 14.5670, Longitude = 121.0456 },
                new Station { Id = 110, Name = "Buendia", RailLineId = 3, SequenceNumber = 10, Latitude = 14.5542, Longitude = 121.0349 },
                new Station { Id = 111, Name = "Ayala", RailLineId = 3, SequenceNumber = 11, Latitude = 14.5491, Longitude = 121.0281 },
                new Station { Id = 112, Name = "Magallanes", RailLineId = 3, SequenceNumber = 12, Latitude = 14.5421, Longitude = 121.0194 },
                new Station { Id = 113, Name = "Taft Avenue", RailLineId = 3, SequenceNumber = 13, Latitude = 14.5376, Longitude = 121.0014 }
            };
            return Ok(mrt3Stations);
        }

        return NotFound("Line not registered in network configuration.");
    }
}