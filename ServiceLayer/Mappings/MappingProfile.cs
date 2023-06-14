using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.About;
using ServiceLayer.DTOs.Author;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Contact;
using ServiceLayer.DTOs.Course;
using ServiceLayer.DTOs.Header;
using ServiceLayer.DTOs.Service;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.DTOs.Title;


namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderDto>().ReverseMap();
            CreateMap<Slider, SliderListDto>().ReverseMap();
            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();

            CreateMap<Title, TitleDto>().ReverseMap();
            CreateMap<Title, TitleListDto>().ReverseMap();
            CreateMap<Title, TitleCreateDto>().ReverseMap();
            CreateMap<Title, TitleUpdateDto>().ReverseMap();

            CreateMap<Header, HeaderDto>().ReverseMap();
            CreateMap<Header, HeaderListDto>().ReverseMap();
            CreateMap<Header, HeaderCreateDto>().ReverseMap();
            CreateMap<Header, HeaderUpdateDto>().ReverseMap();


            CreateMap<Banner, BannerDto>().ReverseMap();
            CreateMap<Banner, BannerListDto>().ReverseMap();
            CreateMap<Banner, BannerCreateDto>().ReverseMap();
            CreateMap<Banner, BannerUpdateDto>().ReverseMap();


            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Service, ServiceListDto>().ReverseMap();
            CreateMap<Service, ServiceCreateDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();

            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactListDto>().ReverseMap();
            CreateMap<Contact, ContactCreateDto>().ReverseMap();
            CreateMap<Contact, ContactUpdateDto>().ReverseMap();


            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<About, AboutListDto>().ReverseMap();
            CreateMap<About, AboutCreateDto>().ReverseMap();
            CreateMap<About, AboutUpdateDto>().ReverseMap();

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CourseListDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(c => c.CourseAuthors
                .Where(ca => ca.CourseId == c.Id)
                .Select(ca => ca.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(src => src.Students.Select(s => s.FullName)));

            CreateMap<Course, CourseCreateDto>().ReverseMap();

            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Author, AuthorListDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(a => a.CourseAuthors
                .Where(ca => ca.CourseId == a.Id)
                .Select(ca => ca.Course.Name)));
            CreateMap<Author, AuthorCreateDto>().ReverseMap();

        }
    }
}
