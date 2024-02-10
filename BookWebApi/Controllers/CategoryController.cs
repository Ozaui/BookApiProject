using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;
using BookWebApi.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _service;
    public CategoryController(ICategoryService service)
    {
        _service = service;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Category> categories = _service.GetAll();
        return Ok(categories);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery]int id) 
    {
        Category category = _service.GetById(id);
        return Ok(category);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody]CategoryAddRequestDto dto)
    {
        _service.Add(dto);
        return Ok("Ekleme başarılı");
    }

}
