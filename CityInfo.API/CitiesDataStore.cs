using CityInfo.API.Models;
using System.Collections.Generic;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            //init dummy data

            Cities = new List<CityDTO>() 
            { 
                new CityDTO()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skycrapper located in Midtown Manhattan."
                        }
                    }
                    
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Cathedral of our lady",
                            Description = "A gothic styled cathedral, conceived by architects Jan and Pietro."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Antwerp Central Station",
                            Description = "The finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Eifel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars, named after something."
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        }
                    }
                }
            };
        }
    }
}
