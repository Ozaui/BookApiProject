using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;
using BookWebApi.Service.Concrete;
using BookWebApi.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _service;

    public AuthorController(IAuthorService service)
    {
        _service = service;
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        Author author = _service.GetById(id);
        return Ok(author);
    }

    [HttpPost("add")]
    public IActionResult Add(AuthorAddRequestDto dto)
    {
        _service.Add(dto);
        return Ok("Ekleme başarılı");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Author> author = _service.GetAll();
        return Ok(author);
    }
}
