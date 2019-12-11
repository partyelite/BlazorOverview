using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorJsInterop
{
    public class BlazorJsUtilsInterop
    {
        private IJSRuntime _jsRuntime;
        public BlazorJsUtilsInterop(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public ValueTask<object> Alert(string message)
        {
            return _jsRuntime.InvokeAsync<object>(
                "blazorUtilsJs.alert",
                message);
        }
    }
}
