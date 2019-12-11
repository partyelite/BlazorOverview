using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace SharedComponents
{
    public class JSInterop
    {
        private IJSRuntime _jsRuntime;

        public JSInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<object> InitializePikaday(ElementReference inputEl, object dotNetObjectRef)
        {
            return await _jsRuntime.InvokeAsync<object>("pikadayJLPrepaidWebInterop.initialize", inputEl, dotNetObjectRef);
        }

        public async Task<object> DisposePikaday(ElementReference inputEl)
        {
            return await _jsRuntime.InvokeAsync<object>("pikadayJLPrepaidWebInterop.dispose", inputEl);
        }
    }
}
