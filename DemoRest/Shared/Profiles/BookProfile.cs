using AutoMapper;
using DemoRest.Model.Models;

namespace DemoRest.Model.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() {
            CreateMap<BookFormInput, Book>();
        }
    }
}
