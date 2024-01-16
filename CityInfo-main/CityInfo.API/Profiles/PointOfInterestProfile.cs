using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile:Profile
    {
        public PointOfInterestProfile() { 
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();
            CreateMap<Models.PointsOfInterestForUpdateDbo, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, Models.PointsOfInterestForUpdateDbo>();
       

        }
    }
}
