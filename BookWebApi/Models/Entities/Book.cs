﻿using BookWebApi.Models.Dtos.RequestDto;

namespace BookWebApi.Models.Entities;

public class Book : Entity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }

    //public static implicit operator Book(BookAddRequestDto dto)
    //{
    //    return new Book()
    //    {
    //        Title = dto.Title,
    //        Description = dto.Description,
    //        Author = dto.Author,
    //        Category = dto.Category,
    //        Price = dto.Price,
    //        Stock = dto.Stock,
    //    };
    //}
    //public static implicit operator Book(BookUpdateRequestDto dto)
    //{
    //    return new Book()
    //    {
    //        Title = dto.Title,
    //        Description = dto.Description,
    //        Author = dto.Author,
    //        Category = dto.Category,
    //        Price = dto.Price,
    //        Stock = dto.Stock,
    //        Id = dto.Id,
    //    };
    //}
}
