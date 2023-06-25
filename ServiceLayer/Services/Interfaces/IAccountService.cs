﻿using ServiceLayer.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task LoginAsync (LoginDto loginDto);
        Task<ApiResponse> RegisterAsync (RegisterDto registerDto);
    }
}
