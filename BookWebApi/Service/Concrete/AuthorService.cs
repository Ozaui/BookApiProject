using AutoMapper;
using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;
using BookWebApi.Repostory;
using BookWebApi.Service.Interfaces;

namespace BookWebApi.Service.Concrete;

public class AuthorService : IAuthorService
{
    private readonly BaseDbContect _context;
    private readonly Mapper _mapper;

    public AuthorService(BaseDbContect context, Mapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void Add(AuthorAddRequestDto dto)
    {
        Author author = _mapper.Map<Author>(dto);
        _context.Author.Add(author);
        _context.SaveChanges();
    }

    public List<Author> GetAll()
    {
        List<Author> authors = _context.Author.ToList();
        return authors;
    }

    public Author GetById(int id)
    {
        Author? author = _context.Author.Find(id);
        if (author == null)
        {
            throw new Exception($"{id}'ye ait Author bulunamadı");
        }
        return author;
    }
}
