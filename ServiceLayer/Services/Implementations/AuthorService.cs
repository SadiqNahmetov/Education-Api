﻿using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Author;
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
        private readonly IMapper _mapper;


        public AuthorService(IAuthorRepository authorRepository, ICourseRepository courseRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
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

       
    }
}
