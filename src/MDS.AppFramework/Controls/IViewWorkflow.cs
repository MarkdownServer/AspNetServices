using System.CodeDom.Compiler;
using System.Text;

using Microsoft.AspNetCore.WebUtilities;

namespace MDS.AppFramework.Controls;

public interface IViewWorkflow : IAppView, IViewState, IAsyncDisposable
{
    bool IsCompleted {get;}

    AggregateException? Exceptions { get; }
    HttpResponseStreamWriter Renderer {get;}
    string Id { get; }
    string Name { get; }
    StringBuilder StringBuilder { get; }

    Task StartAsync(HttpContext context, CancellationToken token);
    Task PreInitAsync(HttpContext context);
    Task InitAsync(HttpContext context);
    Task LoadPageStateAsync(HttpContext context);
    Task ProcessPageAsync(HttpContext context);
    Task PreRenderAsync(HttpContext context);
}