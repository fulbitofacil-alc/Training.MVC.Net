using MVC5Course.Automapper.Domain.BasicDomainExample;
using MVC5Course.Automapper.Models.Basic;
using AutoMapper;

namespace MVC5Course.Automapper.Mapper
{
    public class CustomerMapper
    {
        public static  void Bootstrap()
        {
            AutoMapper.Mapper.CreateMap<Customer, CustomerInfoViewModel>();
                //.ForMember(dest => dest.Name,
                //    opt => opt.MapFrom(src => 
                //        string.Format("{0} {1}", src.FirstName, src.LastName)));

        }
    }
}