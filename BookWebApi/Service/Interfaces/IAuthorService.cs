using BookWebApi.Models.Dtos.RequestDto;
using BookWebApi.Models.Entities;

namespace BookWebApi.Service.Interfaces;

public interface IAuthorService
{
    List<Author> GetAll();
    Author GetById(int id);
    void Add(AuthorAddRequestDto dto);
}
