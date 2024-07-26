using AutoMapper;
using ToDoList.Api.Models.Dtos;
using ToDoList.Domain.Entities;

namespace ToDoList.Api.Mappers;

public class ToDoListMapper : Profile
{
    public ToDoListMapper()
    {
        CreateMap<ToDoListEntity, ToDoListDto>().ReverseMap();
    }
}