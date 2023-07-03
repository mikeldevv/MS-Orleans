using Microsoft.AspNetCore.Mvc;
using MsOrleans.Features;

namespace MsOrleans.Controllers;

public class HelloWorldController : Controller
{
    private readonly IClusterClient _clusterClient;

    public HelloWorldController(IClusterClient clusterClient)
    {
        _clusterClient = clusterClient;
    }

    [HttpGet("/hello/{name}")]
    public async Task<IActionResult> Hello(string name)
    {
        var result = await _clusterClient.GetGrain<IHelloWorldGrain>("AgbadoLand").SayHello(name);
        return Ok(result);
    }
}