using AutoMapper;
using DAL.Models;

namespace QuickApp.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Installment, InstallmentViewModel>();
        }
    }
}