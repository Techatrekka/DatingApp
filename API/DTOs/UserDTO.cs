using System;

namespace API.DTOs;

public class UserDTO
{
    public required string UserName { get; set; }

    public required string token { get; set; }
}
