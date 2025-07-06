using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegisterDTO
{
    [MaxLength(200)]
    public required string Username { get; set; }
    public required string Password { get; set; }
}
