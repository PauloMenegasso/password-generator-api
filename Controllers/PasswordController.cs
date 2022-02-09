using Microsoft.AspNetCore.Mvc;
using password_generator_api.Services;

namespace password_generator_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PasswordController : ControllerBase
{
    private readonly IGeneratePassword generatePassword;

    public PasswordController(IGeneratePassword generatePassword)
    {
        this.generatePassword = generatePassword;
    }

    [HttpGet()]
    public string Get()
    {
        return this.generatePassword.GeneratePassword(12);
    }

    [HttpGet("{number}")]
    public string Get([FromRoute] int number)
    {
        return this.generatePassword.GeneratePassword(number);
    }
}
