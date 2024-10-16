using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp =>
{
    // Use the base address of the WebAssembly host (or any external API).
    return new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
});
await builder.Build().RunAsync();
