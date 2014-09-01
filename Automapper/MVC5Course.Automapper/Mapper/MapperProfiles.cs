using AutoMapper;
using MVC5Course.Automapper.Domain.ProfilesDomain;
using MVC5Course.Automapper.Models.Basic;

namespace MVC5Course.Automapper.Mapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            AutoMapper.Mapper.CreateMap<Person, PersonViewModel>();

            AutoMapper.Mapper.CreateMap<Address, AddressViewModel>()
                .ForMember(x => x.PersonAddressLineOne, opt => opt.MapFrom(source => source.FirstLine))
                .ForMember(x => x.PersonCountryOfResidence, opt => opt.MapFrom(source => source.Country));

            AutoMapper.Mapper.CreateMap<Note, NoteViewModel>();
        }
    }

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            AutoMapper.Mapper.CreateMap<PersonViewModel, Person>();

            AutoMapper.Mapper.CreateMap<AddressViewModel, Address>()
                .ForMember(x => x.FirstLine, opt => opt.MapFrom(source => source.PersonAddressLineOne))
                .ForMember(x => x.Country, opt => opt.MapFrom(source => source.PersonCountryOfResidence));

            AutoMapper.Mapper.CreateMap<NoteViewModel, Note>();
        }
    }

}