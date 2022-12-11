using Microsoft.JSInterop;

namespace BlazorApp.Helpers
{
    public class JavascriptHelper : IJavascriptHelper
    {
        public IJSRuntime jsRuntime {get; set;}

        public JavascriptHelper(IJSRuntime js)
        {
            jsRuntime = js;
        }
        public async Task Confirmation()
        {
            await jsRuntime.InvokeVoidAsync("confirmation");
        }
    }
    public interface IJavascriptHelper
    {
        Task Confirmation();
    }
}
