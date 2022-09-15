using System.Threading;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace UI.Server
{
    public class NullJSRuntime  : IJSRuntime
    {
        public ValueTask<TValue> InvokeAsync<TValue>(string identifier, object?[]? args)
        {           
            return new();
        }

        public ValueTask<TValue> InvokeAsync<TValue>(string identifier, CancellationToken cancellationToken, object?[]? args)
        {            
            return new();
        }
    }
}