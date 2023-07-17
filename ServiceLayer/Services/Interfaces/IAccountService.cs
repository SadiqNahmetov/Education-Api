using ServiceLayer.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task<string?> LoginAsync(LoginDto loginDto);

        Task<ApiResponse> RegisterAsync(RegisterDto registerDto);

        Task ConfirmEmailAsync(string userId, string token);
        Task CreateRoleAsync(RoleDto roleDto);
        Task ResetPasswordAsync(ResetPasswordDto resetPasswordDto);

    }
}
