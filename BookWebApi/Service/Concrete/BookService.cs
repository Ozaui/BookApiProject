using AutoMapper;
using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;
using BookWebApi.Repostory;
using BookWebApi.Service.Interfaces;

namespace BookWebApi.Service.Concrete;

public class BookService : IBookService
{
    private readonly BaseDbContect _context;
    private readonly IMapper _mapper;

    public BookService(BaseDbContect contect, IMapper mapper)
    {
        _context = contect;
        _mapper = mapper;
    }

    public void Add(BookAddRequestDto dto)
    {
        Book book = _mapper.Map<Book>(dto);
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        Book? book = _context.Books.Find(id);
        if(book == null)
        {
            throw new Exception($"{id}'ye ait kitap bulunamadı");
        }
        _context.Books.Remove(book);
        _context.SaveChanges();
    }

    public List<Book> GetAll()
    {
        List<Book> books = _context.Books.ToList();
        return books;
    }

    public Book GetById(int id)
    {
        Book? book = _context.Books.Find(id);
        if (book == null)
        {
            throw new Exception($"{id}'ye ait kitap bulunamadı");
        }
        return book;
    }

    public void Update(BookUpdateRequestDto dto)
    {
        Book? book = _context.Books.Find(dto.Id);
        if (book == null)
        {
            throw new Exception($"{dto.Id}'ye ait kitap bulunamadı");
        }
        book = _mapper.Map<Book>(dto.Id);
        _context.Books.Update(book);
        _context.SaveChanges();
    }
}
