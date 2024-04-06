using Microsoft.AspNetCore.Mvc;
using Task.Application.UseCases.Task.Create;
using Task.Communication.Requests;
using Task.Communication.Responses;
using Task.Infrastructure;

namespace Task.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{


    [HttpPost]
    public IActionResult Create([FromBody] RequestCreateTaskJson request)
    {
        var useCase = new CreateTaskUseCase();
        var response = useCase.Execute(request);

        return Ok(response);
    }
}
