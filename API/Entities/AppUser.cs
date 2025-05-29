using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    [Key]
    public int Id { get; set; }
    //Username and UserName are two separate things in c# as it is a case sensitive language
    // when nullable not enabled .net doesnt know if reference types can be null or not
    public required string UserName { get; set; }
}
