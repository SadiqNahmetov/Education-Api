using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Author;
using ServiceLayer.DTOs.Course;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class AuthorService : IAuthorService
    {

        private readonly IAuthorRepository _authorRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly ICourseAuthorRepository _courseAuthorRepository;
        private readonly IMapper _mapper;


        public AuthorService(IAuthorRepository authorRepository, ICourseRepository courseRepository, IMapper mapper, ICourseAuthorRepository courseAuthorRepository)
        {
            _authorRepository = authorRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseAuthorRepository = courseAuthorRepository;
        }


        public async Task CreateAsync(AuthorCreateDto authorCreateDto)
        {
            if (authorCreateDto.CourseIds != null && authorCreateDto.CourseIds.Any())
            {
                var courses = await _courseRepository.FindAllByExpression(c => authorCreateDto.CourseIds.Contains(c.Id));

                var mapAuthor = _mapper.Map<Author>(authorCreateDto);

                mapAuthor.Image = await authorCreateDto.Photo.GetBytes();

                mapAuthor.CourseAuthors = new List<CourseAuthor>();

                foreach (var course in courses)
                {
                    var courseAuthor = new CourseAuthor
                    {
                        CourseId = course.Id,
                        AuthorId = mapAuthor.Id
                    };
                    mapAuthor.CourseAuthors.Add(courseAuthor);
                }

                await _authorRepository.CreateAsync(mapAuthor);
            }
            else
            {
                throw new Exception("You must select at least one course.");
            }
        }


        public async Task<AuthorDto> GetAsync(int id)
        {
            return _mapper.Map<AuthorDto>(await _authorRepository.GetAsync(id));
        }



        public async Task<List<AuthorListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AuthorListDto>>(await _authorRepository.GetAllWithCoursesAsync());
        }




        public async Task UpdateAsync(int id, AuthorUpdateDto authorUpdateDto)
        {
            if (authorUpdateDto.CourseIds != null && authorUpdateDto.CourseIds.Any())
            {
                var courses = await _courseRepository.FindAllByExpression(c => authorUpdateDto.CourseIds.Contains(c.Id));

                var dbAuthor = await _authorRepository.GetWithCoursesAsync(id);

                await _courseAuthorRepository.DeleteList(dbAuthor.CourseAuthors.ToList());

                foreach (var course in courses)
                {
                    var courseAuthor = new CourseAuthor
                    {
                        AuthorId = id,
                        CourseId = course.Id
                    };

                    dbAuthor.CourseAuthors?.Add(courseAuthor);
                }

                var mapAuthor = _mapper.Map(authorUpdateDto, dbAuthor);

                mapAuthor.Image = await authorUpdateDto.Photo.GetBytes();

                await _authorRepository.UpdateAsync(mapAuthor);
            }
            else
            {
                throw new Exception("You must select at least one author.");
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _authorRepository.DeleteAsync(await _authorRepository.GetAsync(id));
        }

        public async Task SoftDeleteAsync(int id)
        {
           var author = await _authorRepository.GetAsync(id);

            await _authorRepository.SoftDelete(author);
        }
    }
}
