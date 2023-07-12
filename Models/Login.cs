#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginReg.Models;
public class Login
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

}