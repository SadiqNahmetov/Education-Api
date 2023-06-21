using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Author;
using ServiceLayer.DTOs.Student;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository studentRepository, ICourseRepository courseRepository,
           IMapper mapper)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }


        public Task CreateAsync(StudentCreateDto studentCreateDto)
        {
            throw new NotImplementedException();
        }

      

        public async Task<StudentDto> GetAsync(int id)
        {
           return _mapper.Map<StudentDto>(await _studentRepository.GetAsync(id));
        }

        public async Task<List<StudentListDto>> GetAllAsync()
        {
            return _mapper.Map<List<StudentListDto>>(await _studentRepository.GetAllAsync());
        }


        public Task UpdateAsync(int id, StudentUpdateDto studentUpdateDto)
        {
            throw new NotImplementedException();
        }



        public async Task DeleteAsync(int id)
        {
            await _studentRepository.DeleteAsync(await _studentRepository.GetAsync(id));
        }
    }
}
