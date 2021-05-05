using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteBackend.Business.Dtos.UserDtos
{
    public class UserLoginResponseDto
    {
        public string Token { get; set; }
        public int UserId { get; set; }
    }
}
