using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Implementations;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Contact;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repo;

        private readonly IMapper _mapper;

        public ContactService(IMapper mapper, IContactRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task CreateAsync(ContactCreateDto contactCreateDto)
        {
           
            await _repo.CreateAsync(_mapper.Map<Contact>(contactCreateDto));
        }


        public async Task<List<ContactListDto>> GetAllAsync()
        {
            return  _mapper.Map<List<ContactListDto>>(await _repo.GetAllAsync());

            
        }

        public async Task<ContactDto> GetAsync(int id)
        {

            return _mapper.Map<ContactDto>(await _repo.GetAsync(id));

        }

  

        public async Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto)
        {
            var dbContact = await _repo.GetAsync(id);

            _mapper.Map(contactUpdateDto, dbContact);

            await _repo.UpdateAsync(dbContact);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.GetAsync(id));
        }
    }
}
