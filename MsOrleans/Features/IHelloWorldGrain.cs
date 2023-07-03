namespace MsOrleans.Features;

public interface IHelloWorldGrain : IGrainWithStringKey
{
    Task<string> SayHello(string name);
}