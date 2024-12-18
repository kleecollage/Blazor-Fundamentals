using Fundamentals.Repository.Interfaces;

namespace Fundamentals.Repository;

public class MyService: IMyService
{
    public string GetMessage()
    {
        return "Hello World from MyService!";
    }
}