using Task.Communication.Requests;
using Task.Communication.Responses;

namespace Task.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public static readonly List<Infrastructure.Task> task = [];

    public ResponseCreateTaskJson Execute(RequestCreateTaskJson request)
    {
        Validate(request);

        var entity = new Infrastructure.Task
        {
            Name = request.Name,
            Description = request.Description,
        };

        task.Add(entity);

        return new ResponseCreateTaskJson
        {
            Id = entity.Id
        };
    }

    private void Validate(RequestCreateTaskJson request)
    {
        if(string.IsNullOrWhiteSpace(request.Name))
        {
            throw new ArgumentException("O nome informado é inválido");
        }
    }
}
