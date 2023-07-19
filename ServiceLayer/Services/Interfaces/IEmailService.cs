using DomainLayer.Entities;
using ServiceLayer.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmailService
    {

        public void Register(RegisterDto registerDto, string link);
        public void ForgotPassword(AppUser user, string link, ForgotPasswordDto forgotPasswordDto);
    }
}
