using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.About;
using ServiceLayer.DTOs.Account;
using ServiceLayer.DTOs.Author;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Contact;
using ServiceLayer.DTOs.Course;
using ServiceLayer.DTOs.Header;
using ServiceLayer.DTOs.Service;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.DTOs.Student;
using ServiceLayer.DTOs.Title;


namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<Slider, SliderListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<Slider, SliderCreateDto>().ReverseMap();
            CreateMap<Slider, SliderUpdateDto>().ReverseMap();


            CreateMap<Title, TitleDto>().ReverseMap();
            CreateMap<Title, TitleListDto>().ReverseMap();
            CreateMap<Title, TitleCreateDto>().ReverseMap();
            CreateMap<Title, TitleUpdateDto>().ReverseMap();


            CreateMap<Header, HeaderDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<Header, HeaderListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<Header, HeaderCreateDto>().ReverseMap();
            CreateMap<Header, HeaderUpdateDto>().ReverseMap();






            CreateMap<Banner, BannerDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Banner, BannerListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Banner, BannerCreateDto>().ReverseMap();
            CreateMap<Banner, BannerUpdateDto>().ReverseMap();


            CreateMap<Service, ServiceDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Service, ServiceListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Service, ServiceCreateDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();


            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactListDto>().ReverseMap();
            CreateMap<Contact, ContactCreateDto>().ReverseMap();
            CreateMap<Contact, ContactUpdateDto>().ReverseMap();


            CreateMap<About, AboutDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<About, AboutListDto>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();

            CreateMap<About, AboutCreateDto>().ReverseMap();
            CreateMap<About, AboutUpdateDto>().ReverseMap();


            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(c => c.CourseAuthors.Where(ca => ca.CourseId == c.Id).Select(ca => ca.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(c => c.Students.Select(s => s.FullName)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Course, CourseListDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(c => c.CourseAuthors.Where(ca => ca.CourseId == c.Id).Select(ca => ca.Author.Name)))
                .ForMember(dest => dest.StudentFullName, opt => opt.MapFrom(c => c.Students.Select(s => s.FullName)))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();



            CreateMap<Author, AuthorDto>()
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(a => a.CourseAuthors.Where(ca => ca.AuthorId == a.Id).Select(ca => ca.Course.Name)))
                 .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                 .ReverseMap();
            CreateMap<Author, AuthorListDto>()
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(a => a.CourseAuthors.Where(ca => ca.AuthorId == a.Id).Select(ca => ca.Course.Name)))
                 .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                 .ReverseMap();
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();


            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(s => s.Course.Name))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Student, StudentListDto>()
                .ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(s => s.Course.Name))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(s => Convert.ToBase64String(s.Image)))
                .ReverseMap();
            CreateMap<Student, StudentCreateDto>().ReverseMap();
            CreateMap<Student, StudentUpdateDto>().ReverseMap();


            CreateMap<RegisterDto, AppUser>().ReverseMap();
            CreateMap<LoginDto, AppUser>().ReverseMap();
        }
    }
}
