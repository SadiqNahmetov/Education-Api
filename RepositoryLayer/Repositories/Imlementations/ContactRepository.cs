using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Imlementations
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
       public ContactRepository(AppDbContext context):base(context)
        {
        
        }
        
    }
}
