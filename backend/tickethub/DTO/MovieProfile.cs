using AutoMapper;
using tickethub.Entities;
using tickethub.DTO;

namespace tickethub.MappingProfiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDTO>().ReverseMap();
            CreateMap<MovieCast, MovieCastDTO>().ReverseMap();
        }
    }
}
