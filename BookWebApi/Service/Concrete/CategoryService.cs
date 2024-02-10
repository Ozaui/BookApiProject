using AutoMapper;
using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;
using BookWebApi.Repostory;
using BookWebApi.Service.Interfaces;

namespace BookWebApi.Service.Concrete;

public class CategoryService : ICategoryService
{
    private readonly BaseDbContect _context;
    private readonly Mapper _mapper;

    public CategoryService(BaseDbContect context, Mapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Add(CategoryAddRequestDto dto)
    {
        Category category = _mapper.Map<Category>(dto);
        _context.Add(category);
        _context.SaveChanges();
    }

    public List<Category> GetAll()
    {
        List<Category> categories = _context.Categories.ToList();
        return categories;
    }

    public Category GetById(int id)
    {
        Category? category = _context.Categories.Find(id);
        if (category == null)
        {
            throw new Exception($"{id}'ye ait category bulunamadı");
        }
        return category;
    }
}
