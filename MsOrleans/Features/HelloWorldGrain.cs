namespace MsOrleans.Features;

public class HelloWorldGrain : Grain, IHelloWorldGrain
{
    private int _invocationCount = 0;

    public Task<string> SayHello(string name)
    {
        return Task.FromResult(
            $"Hello {name} from {this.GetPrimaryKeyString()} - I've said hello {_invocationCount++} times.");
    }
}