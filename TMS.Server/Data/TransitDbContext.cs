using Microsoft.EntityFrameworkCore;
using TMS.Server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TMS.Server.Data;

public class TransitDbContext : IdentityDbContext<ApplicationUser>
{
    public TransitDbContext(DbContextOptions<TransitDbContext> options)
        : base(options)
    {
    }

    public DbSet<RailLine> RailLines { get; set; } = null!;
    public DbSet<Station> Stations { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RailLine>().HasData(
            new RailLine
            {
                Id = 1,
                Name = "Light Rail Transit Line 1",
                ShortName = "LRT-1",
                PrimaryColor = "#009639"
            },
            new RailLine
            {
                Id = 2,
                Name = "Light Rail Transit Line 2",
                ShortName = "LRT-2",
                PrimaryColor = "#7B1FA2"
            },
            new RailLine
            {
                Id = 3,
                Name = "Metro Rail Transit Line 3",
                ShortName = "MRT-3",
                PrimaryColor = "#005EB8"
            }
        );

        modelBuilder.Entity<Station>().HasData(
            new Station
            {
                Id = 1,
                Name = "North Avenue",
                RailLineId = 3,
                SequenceNumber = 1,
                Latitude = 14.6549,
                Longitude = 121.0304
            },
            new Station
            {
                Id = 2,
                Name = "Quezon Avenue",
                RailLineId = 3,
                SequenceNumber = 2,
                Latitude = 14.6426,
                Longitude = 121.0389
            },
            new Station
            {
                Id = 3,
                Name = "GMA Kamuning",
                RailLineId = 3,
                SequenceNumber = 3,
                Latitude = 14.6348,
                Longitude = 121.0438
            },
            new Station
            {
                Id = 4,
                Name = "Araneta Center-Cubao",
                RailLineId = 3,
                SequenceNumber = 4,
                Latitude = 14.6220,
                Longitude = 121.0567
            },
            new Station
            {
                Id = 5,
                Name = "Santolan-Annapolis",
                RailLineId = 3,
                SequenceNumber = 5,
                Latitude = 14.6109,
                Longitude = 121.0561
            },
            new Station
            {
                Id = 6,
                Name = "Ortigas",
                RailLineId = 3,
                SequenceNumber = 6,
                Latitude = 14.5866,
                Longitude = 121.0560
            },
            new Station
            {
                Id = 27,
                Name = "Shaw Boulevard",
                RailLineId = 3,
                SequenceNumber = 7,
                Latitude = 14.5815,
                Longitude = 121.0536
            },
            new Station
            {
                Id = 28,
                Name = "Boni",
                RailLineId = 3,
                SequenceNumber = 8,
                Latitude = 14.5746,
                Longitude = 121.0489
            },
            new Station
            {
                Id = 29,
                Name = "Guadalupe",
                RailLineId = 3,
                SequenceNumber = 9,
                Latitude = 14.5667,
                Longitude = 121.0451
            },
            new Station
            {
                Id = 30,
                Name = "Buendia",
                RailLineId = 3,
                SequenceNumber = 10,
                Latitude = 14.5547,
                Longitude = 121.0348
            },
            new Station
            {
                Id = 31,
                Name = "Ayala",
                RailLineId = 3,
                SequenceNumber = 11,
                Latitude = 14.5489,
                Longitude = 121.0287
            },
            new Station
            {
                Id = 32,
                Name = "Magallanes",
                RailLineId = 3,
                SequenceNumber = 12,
                Latitude = 14.5386,
                Longitude = 121.0197
            },
            new Station
            {
                Id = 33,
                Name = "Taft Avenue",
                RailLineId = 3,
                SequenceNumber = 13,
                Latitude = 14.5370,
                Longitude = 121.0014
            },
            new Station
            {
                Id = 7,
                Name = "Baclaran",
                RailLineId = 1,
                SequenceNumber = 1,
                Latitude = 14.5176,
                Longitude = 120.9971
            },
            new Station
            {
                Id = 8,
                Name = "EDSA",
                RailLineId = 1,
                SequenceNumber = 2,
                Latitude = 14.5249,
                Longitude = 120.9925
            },
            new Station
            {
                Id = 9,
                Name = "Libertad",
                RailLineId = 1,
                SequenceNumber = 3,
                Latitude = 14.5535,
                Longitude = 120.9975
            },
            new Station
            {
                Id = 10,
                Name = "Gil Puyat",
                RailLineId = 1,
                SequenceNumber = 4,
                Latitude = 14.5587,
                Longitude = 120.9945
            },
            new Station
            {
                Id = 11,
                Name = "Vito Cruz",
                RailLineId = 1,
                SequenceNumber = 5,
                Latitude = 14.5624,
                Longitude = 120.9940
            },
            new Station
            {
                Id = 12,
                Name = "Quirino",
                RailLineId = 1,
                SequenceNumber = 6,
                Latitude = 14.5702,
                Longitude = 120.9918
            },
            new Station
            {
                Id = 13,
                Name = "Pedro Gil",
                RailLineId = 1,
                SequenceNumber = 7,
                Latitude = 14.5768,
                Longitude = 120.9887
            },
            new Station
            {
                Id = 14,
                Name = "United Nations",
                RailLineId = 1,
                SequenceNumber = 8,
                Latitude = 14.5827,
                Longitude = 120.9847
            },
            new Station
            {
                Id = 15,
                Name = "Central Terminal",
                RailLineId = 1,
                SequenceNumber = 9,
                Latitude = 14.5891,
                Longitude = 120.9817
            },
            new Station
            {
                Id = 16,
                Name = "Carriedo",
                RailLineId = 1,
                SequenceNumber = 10,
                Latitude = 14.5994,
                Longitude = 120.9798
            },
            new Station
            {
                Id = 34,
                Name = "Doroteo Jose",
                RailLineId = 1,
                SequenceNumber = 11,
                Latitude = 14.6033,
                Longitude = 120.9822
            },
            new Station
            {
                Id = 35,
                Name = "Bambang",
                RailLineId = 1,
                SequenceNumber = 12,
                Latitude = 14.6106,
                Longitude = 120.9820
            },
            new Station
            {
                Id = 36,
                Name = "Tayuman",
                RailLineId = 1,
                SequenceNumber = 13,
                Latitude = 14.6170,
                Longitude = 120.9825
            },
            new Station
            {
                Id = 37,
                Name = "Blumentritt",
                RailLineId = 1,
                SequenceNumber = 14,
                Latitude = 14.6227,
                Longitude = 120.9822
            },
            new Station
            {
                Id = 38,
                Name = "Abad Santos",
                RailLineId = 1,
                SequenceNumber = 15,
                Latitude = 14.6302,
                Longitude = 120.9818
            },
            new Station
            {
                Id = 39,
                Name = "R. Papa",
                RailLineId = 1,
                SequenceNumber = 16,
                Latitude = 14.6388,
                Longitude = 120.9822
            },
            new Station
            {
                Id = 40,
                Name = "5th Avenue",
                RailLineId = 1,
                SequenceNumber = 17,
                Latitude = 14.6449,
                Longitude = 120.9825
            },
            new Station
            {
                Id = 41,
                Name = "Monumento",
                RailLineId = 1,
                SequenceNumber = 18,
                Latitude = 14.6548,
                Longitude = 120.9830
            },
            new Station
            {
                Id = 42,
                Name = "Balintawak",
                RailLineId = 1,
                SequenceNumber = 19,
                Latitude = 14.6576,
                Longitude = 120.9835
            },
            new Station
            {
                Id = 43,
                Name = "Fernando Poe Jr.",
                RailLineId = 1,
                SequenceNumber = 20,
                Latitude = 14.6578,
                Longitude = 121.0000
            },
            new Station
            {
                Id = 17,
                Name = "Recto",
                RailLineId = 2,
                SequenceNumber = 1,
                Latitude = 14.6039,
                Longitude = 120.9830
            },
            new Station
            {
                Id = 18,
                Name = "Legarda",
                RailLineId = 2,
                SequenceNumber = 2,
                Latitude = 14.6018,
                Longitude = 120.9928
            },
            new Station
            {
                Id = 19,
                Name = "Pureza",
                RailLineId = 2,
                SequenceNumber = 3,
                Latitude = 14.6010,
                Longitude = 121.0056
            },
            new Station
            {
                Id = 20,
                Name = "V. Mapa",
                RailLineId = 2,
                SequenceNumber = 4,
                Latitude = 14.6042,
                Longitude = 121.0170
            },
            new Station
            {
                Id = 21,
                Name = "J. Ruiz",
                RailLineId = 2,
                SequenceNumber = 5,
                Latitude = 14.6103,
                Longitude = 121.0198
            },
            new Station
            {
                Id = 22,
                Name = "Gilmore",
                RailLineId = 2,
                SequenceNumber = 6,
                Latitude = 14.6137,
                Longitude = 121.0228
            },
            new Station
            {
                Id = 23,
                Name = "Betty Go-Belmonte",
                RailLineId = 2,
                SequenceNumber = 7,
                Latitude = 14.6185,
                Longitude = 121.0281
            },
            new Station
            {
                Id = 24,
                Name = "Araneta Center-Cubao",
                RailLineId = 2,
                SequenceNumber = 8,
                Latitude = 14.6227,
                Longitude = 121.0439
            },
            new Station
            {
                Id = 25,
                Name = "Anonas",
                RailLineId = 2,
                SequenceNumber = 9,
                Latitude = 14.6287,
                Longitude = 121.0643
            },
            new Station
            {
                Id = 26,
                Name = "Katipunan",
                RailLineId = 2,
                SequenceNumber = 10,
                Latitude = 14.6307,
                Longitude = 121.0722
            },
            new Station
            {
                Id = 44,
                Name = "Santolan",
                RailLineId = 2,
                SequenceNumber = 11,
                Latitude = 14.6228,
                Longitude = 121.0792
            },
            new Station
            {
                Id = 45,
                Name = "Marikina-Pasig",
                RailLineId = 2,
                SequenceNumber = 12,
                Latitude = 14.6206,
                Longitude = 121.1018
            },
            new Station
            {
                Id = 46,
                Name = "Antipolo",
                RailLineId = 2,
                SequenceNumber = 13,
                Latitude = 14.6258,
                Longitude = 121.1210
            }
        );
    }
}