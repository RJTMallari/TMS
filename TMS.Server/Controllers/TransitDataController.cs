using Microsoft.AspNetCore.Mvc;
using TMS.Server.Models;

[ApiController]
[Route("api/[controller]")]
public class TransitDataController : ControllerBase
{
    [HttpGet("stations/{lineId}")]
    public IActionResult GetStationsByLine(int lineId)
    {
        if (lineId == 1)
        {
            var lrt1Stations = new List<Station>
            {
                new Station { Id = 1, Name = "Fernando Poe Jr. (FPJ)", RailLineId = 1, SequenceNumber = 1, Latitude = 14.6575, Longitude = 121.0211 },
                new Station { Id = 2, Name = "Balintawak", RailLineId = 1, SequenceNumber = 2, Latitude = 14.6574, Longitude = 121.0004 },
                new Station { Id = 3, Name = "Monumento", RailLineId = 1, SequenceNumber = 3, Latitude = 14.6542, Longitude = 120.9838 },
                new Station { Id = 4, Name = "5th Avenue", RailLineId = 1, SequenceNumber = 4, Latitude = 14.6444, Longitude = 120.9835 },
                new Station { Id = 5, Name = "R. Papa", RailLineId = 1, SequenceNumber = 5, Latitude = 14.6361, Longitude = 120.9830 },
                new Station { Id = 6, Name = "Abad Santos", RailLineId = 1, SequenceNumber = 6, Latitude = 14.6285, Longitude = 120.9813 },
                new Station { Id = 7, Name = "Blumentritt", RailLineId = 1, SequenceNumber = 7, Latitude = 14.6227, Longitude = 120.9829 },
                new Station { Id = 8, Name = "Tayuman", RailLineId = 1, SequenceNumber = 8, Latitude = 14.6169, Longitude = 120.9831 },
                new Station { Id = 9, Name = "Bambang", RailLineId = 1, SequenceNumber = 9, Latitude = 14.6111, Longitude = 120.9832 },
                new Station { Id = 10, Name = "Doroteo Jose", RailLineId = 1, SequenceNumber = 10, Latitude = 14.6054, Longitude = 120.9822 },
                new Station { Id = 11, Name = "Carriedo", RailLineId = 1, SequenceNumber = 11, Latitude = 14.5997, Longitude = 120.9809 },
                new Station { Id = 12, Name = "Central Terminal", RailLineId = 1, SequenceNumber = 12, Latitude = 14.5931, Longitude = 120.9816 },
                new Station { Id = 13, Name = "United Nations", RailLineId = 1, SequenceNumber = 13, Latitude = 14.5826, Longitude = 120.9845 },
                new Station { Id = 14, Name = "Pedro Gil", RailLineId = 1, SequenceNumber = 14, Latitude = 14.5768, Longitude = 120.9866 },
                new Station { Id = 15, Name = "Quirino", RailLineId = 1, SequenceNumber = 15, Latitude = 14.5702, Longitude = 120.9889 },
                new Station { Id = 16, Name = "Vito Cruz", RailLineId = 1, SequenceNumber = 16, Latitude = 14.5632, Longitude = 120.9947 },
                new Station { Id = 17, Name = "Gil Puyat", RailLineId = 1, SequenceNumber = 17, Latitude = 14.5543, Longitude = 120.9972 },
                new Station { Id = 18, Name = "Libertad", RailLineId = 1, SequenceNumber = 18, Latitude = 14.5476, Longitude = 120.9985 },
                new Station { Id = 19, Name = "EDSA", RailLineId = 1, SequenceNumber = 19, Latitude = 14.5385, Longitude = 121.0011 },
                new Station { Id = 20, Name = "Baclaran", RailLineId = 1, SequenceNumber = 20, Latitude = 14.5283, Longitude = 120.9984 }
            };
            return Ok(lrt1Stations);
        }


        if (lineId == 2)
        {
            var lrt2stations = new List<Station>
            {
                new Station { Id = 51, Name = "Recto", RailLineId = 2, SequenceNumber = 1, Latitude = 14.6038, Longitude = 120.9839 },
                new Station { Id = 52, Name = "Legarda", RailLineId = 2, SequenceNumber = 2, Latitude = 14.6008, Longitude = 120.9926 },
                new Station { Id = 53, Name = "Pureza", RailLineId = 2, SequenceNumber = 3, Latitude = 14.6018, Longitude = 121.0051 },
                new Station { Id = 54, Name = "V. Mapa", RailLineId = 2, SequenceNumber = 4, Latitude = 14.6042, Longitude = 121.0182 },
                new Station { Id = 55, Name = "J. Ruiz", RailLineId = 2, SequenceNumber = 5, Latitude = 14.6105, Longitude = 121.0261 },
                new Station { Id = 56, Name = "Gilmore", RailLineId = 2, SequenceNumber = 6, Latitude = 14.6135, Longitude = 121.0343 },
                new Station { Id = 57, Name = "Betty Go-Belmonte", RailLineId = 2, SequenceNumber = 7, Latitude = 14.6186, Longitude = 121.0425 },
                new Station { Id = 58, Name = "Araneta Center-Cubao (L2)", RailLineId = 2, SequenceNumber = 8, Latitude = 14.6225, Longitude = 121.0540 },
                new Station { Id = 59, Name = "Anonas", RailLineId = 2, SequenceNumber = 9, Latitude = 14.6281, Longitude = 121.0645 },
                new Station { Id = 60, Name = "Katipunan", RailLineId = 2, SequenceNumber = 10, Latitude = 14.6321, Longitude = 121.0731 },
                new Station { Id = 61, Name = "Santolan", RailLineId = 2, SequenceNumber = 11, Latitude = 14.6219, Longitude = 121.0872 },
                new Station { Id = 62, Name = "Marikina-Pasig", RailLineId = 2, SequenceNumber = 12, Latitude = 14.6232, Longitude = 121.0998 },
                new Station { Id = 63, Name = "Antipolo", RailLineId = 2, SequenceNumber = 13, Latitude = 14.6247, Longitude = 121.1214 }
            };
            return Ok(lrt2stations);
        }

        if (lineId == 3)
        {
            var mrt3Stations = new List<Station>
            {
                new Station { Id = 101, Name = "North Avenue", RailLineId = 3, SequenceNumber = 1, Latitude = 14.6531, Longitude = 121.0307 },
                new Station { Id = 102, Name = "Quezon Avenue", RailLineId = 3, SequenceNumber = 2, Latitude = 14.6425, Longitude = 121.0379 },
                new Station { Id = 103, Name = "GMA-Kamuning", RailLineId = 3, SequenceNumber = 3, Latitude = 14.6353, Longitude = 121.0433 },
                new Station { Id = 104, Name = "Araneta Center-Cubao", RailLineId = 3, SequenceNumber = 4, Latitude = 14.6221, Longitude = 121.0526 },
                new Station { Id = 105, Name = "Santolan-Anonas", RailLineId = 3, SequenceNumber = 5, Latitude = 14.6079, Longitude = 121.0564 },
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