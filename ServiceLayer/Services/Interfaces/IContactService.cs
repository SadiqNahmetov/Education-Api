using ServiceLayer.DTOs.Contact;
using ServiceLayer.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IContactService
    {
        Task<List<ContactListDto>> GetAllAsync();

        Task<ContactDto> GetAsync(int id);

        Task CreateAsync(ContactCreateDto contactCreateDto);

        Task UpdateAsync(int id, ContactUpdateDto contactUpdateDto);

      

    }
}
