using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Account
{
    public class ResetPasswordDto
    {
        public string? newPassword { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
    }
}
