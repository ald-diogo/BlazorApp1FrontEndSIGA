using BlazorApp1FrontEndSIGA;
using BlazorApp1FrontEndSIGA.Service;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.ComponentModel;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
object obj = builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, BlazorApp1FrontEndSIGA.CustomAuthenticationStateProvider>();
builder.Services.AddScoped<UserService>();

builder.Services.AddHttpClient("GestaoAcademica.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("GestaoAcademica.ServerAPI"));

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();

internal class WebAssemblyHostBuilder
{
    internal static object CreateDefault(string[] args)
    {
        throw new NotImplementedException();
    }
}

internal class BaseAddressAuthorizationMessageHandler
{
}

internal class HeadOutlet : IComponent
{
    public ISite? Site { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event EventHandler? Disposed;

    private RenderHandle _renderHandle;

    public void Attach(RenderHandle renderHandle)
    {
        _renderHandle = renderHandle;
        // Implementação necessária para evitar erros
        _renderHandle.Render(BuildRenderTree);
    }

    private object BuildRenderTree(object arg)
    {
        throw new NotImplementedException();
    }

    private void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.AddContent(0, "Head Outlet");
    }

    public class RenderHandle
    {
        internal void Render(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task SetParametersAsync(ParameterView parameters)
    {
        // Implementação necessária para evitar erros
        return Task.CompletedTask;
    }
    public class ParameterView
    {
    }
}

internal class RenderTreeBuilder
{
    internal void AddContent(int v1, string v2)
    {
        throw new NotImplementedException();
    }
}