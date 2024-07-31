using AutoMapper;
using LocalGym.Models;

namespace LocalGym.Profiles
{
    public class GymProfile : Profile
    {
        public GymProfile()
        {
            CreateMap<Member, Modelsample>();
            CreateMap<Trainer,ModelTrainer>();
            CreateMap<ModelTrainer,Trainer>();
            CreateMap<UpdateTrainer, Trainer>();
            CreateMap<Session ,ModelSession>();
        }
    }
}
