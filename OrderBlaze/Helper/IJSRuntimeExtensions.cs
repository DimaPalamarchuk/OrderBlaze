using Microsoft.JSInterop;

namespace OrderBlaze.Helper
{
    public static class IJSRuntimeExtensions
    {

        // For the Toastr
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "error", message);
        }

        // For the Sweetalert 
        public static async Task SweatalertSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showSwal", "success", message);
        }
        public static async Task SweetalertError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showSwal", "error", message);
        }
    }
}
