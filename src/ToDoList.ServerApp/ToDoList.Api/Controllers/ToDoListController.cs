using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Api.Models.Dtos;
using ToDoList.Application.Services;
using ToDoList.Domain.Entities;

namespace ToDoList.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ToDoListController(IToDoListService toDoListService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async ValueTask<IActionResult> GetAll()
    {
        var result = await toDoListService.GetAllAsync(true, HttpContext.RequestAborted);

        return result.Any() ? Ok(mapper.Map<IEnumerable<ToDoListDto>>(result)) : NotFound();
    }

    [HttpGet("{id:guid}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await toDoListService.GetByIdAsync(id, true, HttpContext.RequestAborted);

        return result is not null ? Ok(result) : NotFound();
    }

    [HttpPost]
    public async ValueTask<IActionResult> Create([FromBody] ToDoListDto dto)
    {
        return Ok(await toDoListService.CreateAsync(mapper.Map<ToDoListEntity>(dto), true, HttpContext.RequestAborted));
    }

    [HttpPut]
    public async ValueTask<IActionResult> Update(ToDoListDto dto)
    {
        var result = await toDoListService.GetByIdAsync(dto.Id, true, HttpContext.RequestAborted);

        if (result is null)
            return NotFound();

        return Ok(await toDoListService.UpdateAsync(mapper.Map<ToDoListEntity>(dto), true, HttpContext.RequestAborted));
    }

    [HttpDelete]
    public async ValueTask<IActionResult> Delete(ToDoListDto dto)
    {
        var result = await toDoListService.DeleteByIdAsync(dto.Id, true, HttpContext.RequestAborted);

        return result is not null ? Ok() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async ValueTask<IActionResult> DeleteById([FromRoute] Guid id)
    {
        var result = await toDoListService.DeleteByIdAsync(id, true, HttpContext.RequestAborted);

        return result is not null ? Ok() : NotFound();
    }
}