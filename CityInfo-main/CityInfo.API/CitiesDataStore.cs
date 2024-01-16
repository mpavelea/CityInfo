using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        //public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() {
            //DUMMY DATA
            Cities = new List<CityDto>()
            {
                new CityDto() {
                    Id = 1,
                    Name = "New York",
                    Description="Cuz' baby I'm from New Yoooork.",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Central Park",
                            Description="The most visited urban park in US"

                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name="Empire State Building",
                            Description="A 102-story skycraper located in Midtown Manhattan"
                        }
                    }
                },
                new CityDto() { 
                    Id = 2,
                    Name="Treviso",
                    Description="it has an airport close to Venice",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=3,
                            Name="Point od int 3",
                            Description="Another description for treviso"

                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name="Point od int 4",
                            Description="Another description for trevisooo"
                        }
                    }
                },
                new CityDto() {
                    Id = 3,
                    Name="Paris",
                    Description="The city of love",
                    PointsOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=5,
                            Name="Eiffel tower",
                            Description="Very big beautiful pieces of metal"

                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name="Cafe de flore",
                            Description="For coffee lovers"
                        }
                    }

                }

            };
        }
    }
}
